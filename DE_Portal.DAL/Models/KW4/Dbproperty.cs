using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Dbproperty
    {
        public string Parameter { get; set; }
        public int? DeviceId { get; set; }
        public string Value { get; set; }
        public DateTime Ts { get; set; }
        public string ParamShort { get; set; }
        public string InstanceName { get; set; }
    }
}
