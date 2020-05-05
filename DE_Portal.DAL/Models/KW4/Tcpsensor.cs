using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Tcpsensor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int UpDown { get; set; }
        public string Ipaddress { get; set; }
        public int Port { get; set; }
        public int MustCompare { get; set; }
        public string Request { get; set; }
        public string ExpectedResponse { get; set; }
        public DateTime? LastPullStart { get; set; }
        public DateTime? LastPullEnd { get; set; }
        public int Enabled { get; set; }
        public DateTime Ts { get; set; }
        public int? HostId { get; set; }
    }
}
