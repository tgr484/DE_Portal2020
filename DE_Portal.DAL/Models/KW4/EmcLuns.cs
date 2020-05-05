using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EmcLuns
    {
        public string Emcid { get; set; }
        public int? LunNumber { get; set; }
        public string LunName { get; set; }
        public double? Capacity { get; set; }
        public string StoragePool { get; set; }
        public string RaidType { get; set; }
    }
}
