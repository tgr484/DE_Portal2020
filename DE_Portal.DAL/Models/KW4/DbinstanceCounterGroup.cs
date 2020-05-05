using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DbinstanceCounterGroup
    {
        public int Id { get; set; }
        public int DbinstanceTypeId { get; set; }
        public string Name { get; set; }
    }
}
