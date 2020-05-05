using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InsidePortSensor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int InsidePortTypeId { get; set; }
        public string InsidePortName { get; set; }
        public int Enabled { get; set; }
        public int? CurrentStatus { get; set; }
        public DateTime Ts { get; set; }
    }
}
