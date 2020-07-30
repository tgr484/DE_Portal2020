using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.Models
{
    public class AlertsModel
    {
        public IEnumerable<SdsAlert> SdsAlerts { get; set; }
        public IEnumerable<SdsAlert> SdsDeletedAlerts { get; set; }

        public AlertsModel(IEnumerable<SdsAlert> sdsAlerts, IEnumerable<SdsAlert> sdsDeletedAlerts)
        {
            SdsAlerts = sdsAlerts;
            SdsDeletedAlerts = sdsDeletedAlerts;
        }
    }

    public class SdsAlert
    {
        public SdsAlert()
        {
            
        }

        public int ID { get; set; }
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public int ClientId { get; set; }
        public string AlertType { get; set; }
        public string AlertMessage { get; set; }
        public string AlertValue { get; set; }
        public string AlertCounter { get; set; }
        public DateTime LastUpdateTS { get; set; }
        public DateTime StatusSetTS { get; set; }
        public string Criticality { get; set; }
        public DateTime ts { get; set; }
        public string Comment { get; set; }
        public string LongDesc { get; set; }
        public string UID { get; set; }
        public string EscallationProcedure { get; set; }
    }
}
