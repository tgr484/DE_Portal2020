using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SumitomoDrives
    {
        public int Id { get; set; }
        public DateTime Ts { get; set; }
        public string Host { get; set; }
        public string Drive { get; set; }
        public long? Size { get; set; }
        public long? Used { get; set; }
        public DateTime? LastDt { get; set; }
    }
}
