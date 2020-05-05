using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InternalVendor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Services { get; set; }
        public string Account { get; set; }
        public string EscalationProcedure { get; set; }
        public string Location { get; set; }
        public string Info { get; set; }
        public string Notes { get; set; }
        public string SalesName { get; set; }
        public string SalesPhone { get; set; }
        public string SalesFax { get; set; }
        public string Mrc { get; set; }
        public DateTime? ContractEnd { get; set; }
        public byte[] Version { get; set; }
        public string SalesEmail { get; set; }
        public string Type { get; set; }
    }
}
