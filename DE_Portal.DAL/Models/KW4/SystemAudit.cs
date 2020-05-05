using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SystemAudit
    {
        public DateTime Date { get; set; }
        public byte[] Host { get; set; }
        public int Event { get; set; }
        public string Data { get; set; }
    }
}
