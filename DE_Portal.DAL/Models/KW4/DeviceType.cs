using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceType
    {
        public int Id { get; set; }
        public string DeviceType1 { get; set; }
        public string DeviceTypeDescription { get; set; }
        public DateTime Ts { get; set; }
        public string Picture { get; set; }
    }
}
