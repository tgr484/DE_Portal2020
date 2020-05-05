using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DbunusedIndexes
    {
        public int Id { get; set; }
        public int? DeviceId { get; set; }
        public string Instance { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string IndexName { get; set; }
        public string Columns { get; set; }
        public string Include { get; set; }
        public int? UserSeeks { get; set; }
        public int? UserScans { get; set; }
        public int? UserLookups { get; set; }
        public int? UserUpdates { get; set; }
        public int? TableRows { get; set; }
        public string Ts { get; set; }
    }
}
