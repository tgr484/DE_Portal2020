using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class PostgreSqlsensor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string HostName { get; set; }
        public string HostIp { get; set; }
        public int Port { get; set; }
        public string DatabaseName { get; set; }
        public int? Enabled { get; set; }
        public DateTime? Ts { get; set; }
    }
}
