using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractDetailsRenewal
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid Details { get; set; }
        public DateTime RenewalDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PricingChanges { get; set; }

        public virtual ContractDetails DetailsNavigation { get; set; }
    }
}
