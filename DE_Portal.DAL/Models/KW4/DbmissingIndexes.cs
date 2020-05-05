using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DbmissingIndexes
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Instance { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string IndexName { get; set; }
        public string Columns { get; set; }
        public string Include { get; set; }
        public double? AvgEstimatedImpact { get; set; }
        public DateTime Ts { get; set; }
    }
}
