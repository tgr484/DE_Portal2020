using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Bpmitems20190208
    {
        public int Id { get; set; }
        public int? InstanceId { get; set; }
        public string Type { get; set; }
        public string Pattern { get; set; }
        public int Enabled { get; set; }
        public string Eta { get; set; }
        public int? BackupItemId { get; set; }
        public long? MinSize { get; set; }
    }
}
