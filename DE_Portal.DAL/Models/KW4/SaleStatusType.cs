using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SaleStatusType
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string StatusShortName { get; set; }
        public int? FunnelOrder { get; set; }
    }
}
