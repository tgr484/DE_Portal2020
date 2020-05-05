using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceAgentProxy
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int AgentProxyId { get; set; }
        public string HostName { get; set; }
        public string Credentials { get; set; }
        public DateTime? LastReported { get; set; }
        public string LastStatus { get; set; }
        public string LastError { get; set; }
        public int? Enabled { get; set; }

        public virtual AgentProxy AgentProxy { get; set; }
        public virtual Device Device { get; set; }
    }
}
