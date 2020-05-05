using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EmcStorageGroups
    {
        public string Emcid { get; set; }
        public string StorageGroupName { get; set; }
        public string Luns { get; set; }
        public string AttachedServers { get; set; }
    }
}
