using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DbfragmentedIndexes
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Instance { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string IndexName { get; set; }
        public double Fragmentation { get; set; }
        public DateTime Ts { get; set; }
    }
}
