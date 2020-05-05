using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.RawSqlHelpers
{
    public static class ChartsSqlHelper
    {
        public static string ClosedTicketsQuery()
        {
            return @"IF EXISTS(SELECT * FROM Ticket WHERE ClientID = @ClientID 
                            AND StatusID IN (3) AND Class IN (1, 2, 3, 4) 
                            AND DATEPART(year, CloseDate) = DATEPART(year, @NowDate)                        
                            AND DATEPART(month, CloseDate) = DATEPART(month, @NowDate))
                        SELECT 
                            COUNT(*) AS TotalTickets,
                            SUM(CASE WHEN Class = 1 THEN 1 ELSE 0 END) AS CritProdTicktes,
                            SUM(CASE WHEN Class = 2 THEN 1 ELSE 0 END) AS CritNonProdTicktes,
                            SUM(CASE WHEN Class = 3 THEN 1 ELSE 0 END) AS NonCritTicktes,
                            SUM(CASE WHEN Class = 4 THEN 1 ELSE 0 END) AS GeneralTicktes,
                            SUM(ISNULL(HoursSpent, 0)) AS Hours
                        FROM Ticket
                        WHERE ClientID = @ClientID
                        
                            AND StatusID IN(3)-- closed only
                        
                            AND Class IN(1, 2, 3, 4)
                        
                            AND DATEPART(year, CloseDate) = DATEPART(year, @NowDate)
                        
                            AND DATEPART(month, CloseDate) = DATEPART(month, @NowDate)
                        GROUP BY ClientID
                        
                        ELSE
                        SELECT 
                            0 TotalTickets,
                            0 AS CritProdTicktes,
                            0 AS CritNonProdTicktes,
                            0 AS NonCritTicktes,
                            0 AS GeneralTicktes,
                            0 AS Hours";
        }

        public static string OpenTicketsQuery()
        {
            return @"IF EXISTS(SELECT * FROM Ticket WHERE ClientID = @ClientID AND StatusID IN (2, 8, 9))
                     SELECT ClientID, 
                     	COUNT(*) AS TotalTickets,
                     	SUM(CASE WHEN StatusID = 2 THEN 1 ELSE 0 END) AS InProcessTicktes,
                     	SUM(CASE WHEN StatusID = 8 THEN 1 ELSE 0 END) AS PendingTicktes,
                     	SUM(CASE WHEN StatusID = 9 THEN 1 ELSE 0 END) AS ClosePendingTicktes
                     FROM Ticket
                     WHERE ClientID = @ClientID
                     	AND StatusID IN (2, 8, 9)	-- In process, Pending, Close Pending
                     GROUP BY ClientID
                     
                     ELSE
                     SELECT @ClientID, 
                     	0 AS TotalTickets,
                     	0 AS InProcessTicktes,
                     	0 AS PendingTicktes,
                     	0 AS ClosePendingTicktes";
        }

        public static string AlertsQuery()
        {
            return @"IF EXISTS(SELECT * FROM Alert a INNER JOIN Device d on d.ID = a.DeviceID WHERE d.ClientID = @ClientID)
                     SELECT d.ClientID, 
                     	COUNT(*) AS TotalAlerts
                     	, SUM(CASE WHEN AlertStatus = 1 THEN 1 ELSE 0 END) AS ActiveAlerts
                     	, SUM(CASE WHEN AlertStatus = 2 THEN 1 ELSE 0 END) AS SuspendedAlerts
                     	, SUM(CASE WHEN AlertStatus = 3 THEN 1 ELSE 0 END) AS InProcessAlerts
                     	, SUM(CASE WHEN AlertStatus = 4 THEN 1 ELSE 0 END) AS IgnoredAlerts
                     	, SUM(CASE WHEN AlertStatus = 5 THEN 1 ELSE 0 END) AS WatchedAlerts
                     FROM Alert a
                     INNER JOIN Device d on d.ID = a.DeviceID
                     WHERE d.ClientID = @ClientID
                     GROUP BY d.ClientID
                     
                     ELSE
                     SELECT @ClientID, 
                     	0 AS TotalAlerts
                     	, 0 AS ActiveAlerts
                     	, 0 AS SuspendedAlerts
                     	, 0 AS InProcessAlerts
                     	, 0 AS IgnoredAlerts
                     	, 0 AS WatchedAlerts";
        }

        public static string AlertsSumaryQuery()
        {
            return "EXEC [spAlertsSummaryReport_Portal] @ClientID, @NowDate";
        }

        public static string HardwareFailuresSummary()
        {
            return @"SELECT
                         ISNULL(SUM(CASE WHEN DATEPART(year, DeviceAudit.CreatedDate) = DATEPART(year, GETDATE()) THEN 1 ELSE 0 END), 0) AS Year2Date,
                         ISNULL(SUM(CASE WHEN DeviceAuditItem.IsResolved is null THEN 1 ELSE 0 END), 0) AS NotResolved
                     FROM DeviceAuditItem
                     INNER JOIN Device ON DeviceAuditItem.DeviceId = Device.Id 
                     INNER JOIN DeviceAudit ON DeviceAudit.Id = DeviceAuditItem.DeviceAuditId
                     WHERE                                             
                     	Device.ClientID = @ClientID
                     	AND (DeviceAuditItem.Attention = 1 OR DeviceAuditItem.NotAvaible = 1 OR DeviceAuditItem.HardDrive = 1 OR DeviceAuditItem.PowerSupply = 1)";
        }

        public static string HardwareFailuresDetails()
        {
            return @"SELECT 
                    	Device.Id, 
                    	Device.DeviceName, 
                    	UPPER(LTRIM(RTRIM(Device.Location))) as Location, 
                    	Device.LedLocation,
                    	DeviceAuditItem.Note, 
                    	DeviceAuditItem.Ok, 
                    	DeviceAuditItem.Attention, 
                    	DeviceAuditItem.NotAvaible, 
                    	DeviceAuditItem.HardDrive, 
                    	DeviceAuditItem.PowerSupply, 
                    	DeviceAuditItem.IsResolved,
                    		(SELECT MAX(DeviceAuditFollowUp.FollowUpDate) FROM DeviceAuditFollowUp WHERE DeviceAuditFollowUp.DeviceAuditItemId = DeviceAuditItem.Id) as MaxFollowUpDate
                    FROM DeviceAuditItem
                    INNER JOIN Device ON DeviceAuditItem.DeviceId = Device.Id 
                    WHERE                                             
                    	Device.ClientID = @ClientID
                    	AND DeviceAuditItem.IsResolved is null 
                    	AND (DeviceAuditItem.Attention = 1 OR DeviceAuditItem.NotAvaible = 1 OR DeviceAuditItem.HardDrive = 1 OR DeviceAuditItem.PowerSupply = 1)
                    ORDER BY Device.DeviceName";
        }
    }
}
