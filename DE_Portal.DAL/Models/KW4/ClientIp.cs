using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientIp
    {
        public long IpAddress { get; set; }
        public int? ClientId { get; set; }
        public int? DeviceId { get; set; }
        public string DeviceRole { get; set; }
        public string DeviceName { get; set; }
        public string Comments { get; set; }
        public int? SubnetId { get; set; }
        public long? TranslationIp { get; set; }
    }
}
