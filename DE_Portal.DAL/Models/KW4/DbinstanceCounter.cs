using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DbinstanceCounter
    {
        public int Id { get; set; }
        public int DbinstanceTypeId { get; set; }
        public int? DbinstanceCounterGroupId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int SortOrder { get; set; }
    }
}
