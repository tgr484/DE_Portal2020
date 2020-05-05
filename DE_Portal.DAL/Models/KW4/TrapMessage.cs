using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TrapMessage
    {
        public int Id { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public string SenderIp { get; set; }
        public string EventId { get; set; }
        public string Oid { get; set; }
    }
}
