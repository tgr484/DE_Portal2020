using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProcessToDevice
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int ProcessId { get; set; }
        public int CurrentStatus { get; set; }
        public DateTime TsOfCurrentStatus { get; set; }
        public int HeartBeatId { get; set; }
        public DateTime Ts { get; set; }
        public int? NotifyClientAfterMinutes { get; set; }
    }
}
