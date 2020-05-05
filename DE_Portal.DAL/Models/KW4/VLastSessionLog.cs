using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class VLastSessionLog
    {
        public int Id { get; set; }
        public int? HeartBeatId { get; set; }
        public string SessionType { get; set; }
        public int? DeviceId { get; set; }
        public int? SessionLogStatusId { get; set; }
        public DateTime Ts { get; set; }
    }
}
