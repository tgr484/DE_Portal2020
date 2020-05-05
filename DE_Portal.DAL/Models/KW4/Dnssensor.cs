using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Dnssensor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int UpDown { get; set; }
        public string Domain { get; set; }
        public string Host { get; set; }
        public DateTime? LastPullStart { get; set; }
        public DateTime? LastPullEnd { get; set; }
        public int Enabled { get; set; }
        public DateTime Ts { get; set; }
    }
}
