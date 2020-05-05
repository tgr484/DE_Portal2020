using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class MonitoringHistory
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public int Client { get; set; }
        public DateTime Date { get; set; }
        public string Changes { get; set; }

        public virtual Client ClientNavigation { get; set; }
    }
}
