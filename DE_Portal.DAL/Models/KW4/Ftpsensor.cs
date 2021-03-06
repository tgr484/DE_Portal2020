﻿using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Ftpsensor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int UpDown { get; set; }
        public string Ftpaddress { get; set; }
        public int Port { get; set; }
        public int ConnectionTimeOut { get; set; }
        public DateTime? LastPullStart { get; set; }
        public DateTime? LastPullEnd { get; set; }
        public int Enabled { get; set; }
        public DateTime Ts { get; set; }
    }
}
