﻿using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Vpnmanager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? DeviceId { get; set; }
        public string PassKey { get; set; }
        public string Ip { get; set; }
        public DateTime? LastReported { get; set; }
    }
}
