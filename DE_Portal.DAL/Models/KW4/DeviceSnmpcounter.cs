using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceSnmpcounter
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public int? PullerId { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public string CommunityString { get; set; }
        public string Oid { get; set; }
        public int? Enabled { get; set; }
    }
}
