using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ServicesPeriods
    {
        public int Id { get; set; }
        public int? ProcessToDeviceId { get; set; }
        public int? DeviceId { get; set; }
        public int? FromHours { get; set; }
        public int? FromMinutes { get; set; }
        public int? ToHours { get; set; }
        public int? ToMinutes { get; set; }
        public DateTime? Ts { get; set; }
        public string Days { get; set; }
    }
}
