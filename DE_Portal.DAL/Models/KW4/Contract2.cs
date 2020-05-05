using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Contract2
    {
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public int? Client { get; set; }
        public int? Vendor { get; set; }
        public int? Partner { get; set; }
        public int? BillTo { get; set; }
        public string Description { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Quote { get; set; }
        public string Po { get; set; }
        public string ContractType { get; set; }

        public virtual Contract2Party ClientNavigation { get; set; }
        public virtual Contract2Party PartnerNavigation { get; set; }
        public virtual Contract2Party VendorNavigation { get; set; }
    }
}
