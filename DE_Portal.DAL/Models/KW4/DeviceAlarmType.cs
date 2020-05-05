using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceAlarmType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public DateTime Ts { get; set; }
    }
}
