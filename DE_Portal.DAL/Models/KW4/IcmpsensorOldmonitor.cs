using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class IcmpsensorOldmonitor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int? HostId { get; set; }
        public int UpDown { get; set; }
        public string Ipaddress { get; set; }
        public int PacketSize { get; set; }
        public int SuccessRate { get; set; }
        public DateTime? LastPullStart { get; set; }
        public DateTime? LastPullEnd { get; set; }
        public int Enabled { get; set; }
        public DateTime Ts { get; set; }
    }
}
