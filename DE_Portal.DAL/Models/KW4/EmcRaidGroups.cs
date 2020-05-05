using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EmcRaidGroups
    {
        public string Emcid { get; set; }
        public int? RaidGroupId { get; set; }
        public string RaidType { get; set; }
        public double? TotalSpaceGb { get; set; }
        public double? FreeSpaceGb { get; set; }
        public double? ContiguousFreeSpaceGb { get; set; }
        public string Luns { get; set; }
    }
}
