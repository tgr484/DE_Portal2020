using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class MonitoringAdjustments
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int PalId { get; set; }
        public int Enabled { get; set; }
        public string Modifier { get; set; }
        public DateTime? Ts { get; set; }
    }
}
