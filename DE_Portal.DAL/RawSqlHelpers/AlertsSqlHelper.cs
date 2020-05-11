using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.RawSqlHelpers
{
    public static class AlertsSqlHelper
    {
        public static string SdsAlerts()
        {
            return @"SELECT A.ID, A.DeviceID, D.DeviceName, D.ClientID, 
                        A.AlertType, A.AlertMessage, A.AlertValue, A.AlertCounter, 
                        A.LastUpdateTS, A.StatusSetTS, A.Criticality, A.ts, 
                        --dbo.fnGetAlertNotificationHistory(A.ID) NotificationHistory, --UNCOMMENT THEN RELEASE
                        A.Comment, CASE WHEN ISNULL(ANS.Status,0) = 1 THEN 'Client Suppressed' ELSE AST.LongDesc END LongDesc, Users.UID , D.EscallationProcedure
                    FROM Alert AS A 
                    LEFT JOIN Users ON A.StatusSetAdmin = Users.ID 
                    LEFT JOIN Device AS D ON A.DeviceID = D.ID 
                    LEFT JOIN AlertStatusType AS AST ON A.AlertStatus = AST.ID 
                    LEFT JOIN AlertNotificationStatus AS ANS ON A.ID=ANS.AlertId
                    WHERE (D.ClientID = @ClientID)
                    ORDER BY A.ID DESC";
        }

        public static string Sds_DeletedAlerts()
        {
            return @"SELECT TOP 20 DA.ID,
                         DA.DeviceID,
                         D.DeviceName,
                         D.ClientID,
                         DA.AlertType,
                         DA.AlertMessage,
                         DA.AlertValue,
                         DA.AlertCounter,
                         DA.LastUpdateTS,
                         DA.StatusSetTS,
                         DA.Criticality,
                         DA.ts,
                         DA.Comment,
                         AST.LongDesc,
                         U.UID
                         , D.EscallationProcedure
                     FROM DeletedAlert AS DA
                         LEFT JOIN Users AS U ON DA.StatusSetAdmin=U.ID
                         LEFT JOIN Device AS D ON DA.DeviceID=D.ID
                         LEFT JOIN AlertStatusType AS AST ON DA.AlertStatus=AST.ID 
                     WHERE D.ClientID=@ClientID
                     ORDER BY DA.ID DESC";
        }
    }
}
