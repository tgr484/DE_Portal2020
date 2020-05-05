using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Vendor
    {
        public Vendor()
        {
            ContractDetails = new HashSet<ContractDetails>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public virtual ICollection<ContractDetails> ContractDetails { get; set; }
    }
}
