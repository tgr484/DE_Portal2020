using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceAlertLevels
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string ValueName { get; set; }
        public int Enabled { get; set; }
        public int? WarningValue { get; set; }
        public int? NewValue { get; set; }
        public string Modifier { get; set; }
        public DateTime? Ts { get; set; }
    }
}
