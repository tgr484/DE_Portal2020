using Dapper;
using DE_Portal.DAL.RawSqlHelpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DE_Portal2020.Models
{
    public class ChartsModel
    {
        public ClosedTickets ClosedTickets { get; set; }

        public OpenTickets OpenTickets { get; set; }

        public Alerts Alerts { get; set; }

        public IEnumerable<AlertsSummary> AlertsSummary { get; set; }

        public HardwareFailureSummary HardwareFailureSummary { get; set; }

        public IEnumerable<HardwareFailureDetails> HardwareFailureDetails { get; set; }

        public ChartsModel(ClosedTickets closedTickets,
            OpenTickets openTickets, Alerts alerts,
            IEnumerable<AlertsSummary> alertsSummary,
            HardwareFailureSummary hardwareFailureSummary,
            IEnumerable<HardwareFailureDetails> hardwareFailureDetails)
        {
            ClosedTickets = closedTickets;
            OpenTickets = openTickets;
            Alerts = alerts;
            AlertsSummary = alertsSummary;
            HardwareFailureSummary = hardwareFailureSummary;
            HardwareFailureDetails = hardwareFailureDetails;
        }
    }

    public class ClosedTickets
    {
        public int ClientID { get; set; }
        public int TotalTickets { get; set; }
        public int CritProdTicktes { get; set; }
        public int CritNonProdTicktes { get; set; }
        public int NonCritTicktes { get; set; }
        public int GeneralTicktes { get; set; }
        public int Hours { get; set; }

        public ClosedTickets()
        {

        }
    }

    public class OpenTickets
    {
        public int ClientID { get; set; }
        public int TotalTickets { get; set; }
        public int InProcessTicktes { get; set; }
        public int PendingTicktes { get; set; }
        public int ClosePendingTicktes { get; set; }
        public OpenTickets()
        {
        }
    }

    public class Alerts
    {
        public Alerts()
        {
        }
        public int ClientID { get; set; }
        public int TotalAlerts { get; set; }
        public int ActiveAlerts { get; set; }
        public int SuspendedAlerts { get; set; }
        public int InProcessAlerts { get; set; }
        public int IgnoredAlerts { get; set; }
        public int WatchedAlerts { get; set; }
    }

    public class AlertsSummary
    {
        public AlertsSummary()
        {
        }

        public string v { get; set; }
        public string value { get; set; }
    }

    public class HardwareFailureSummary
    {
        public HardwareFailureSummary()
        {
        }

        public int Year2Date { get; set; }
        public int NotResolved { get; set; }
    }

    public class HardwareFailureDetails
    {
        public HardwareFailureDetails()
        {
        }

        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string Location { get; set; }
        public string LedLocation { get; set; }
        public string Note { get; set; }
        public bool Ok { get; set; }
        public bool Attention { get; set; }
        public bool NotAvaible { get; set; }
        public bool HardDrive { get; set; }
        public bool PowerSupply { get; set; }
        public bool IsResolved { get; set; }
        public DateTime MaxFollowUpDate { get; set; }

    }
}
