using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractPartnerMap
    {
        public ContractPartnerMap()
        {
            ContractPartnerSecondaryContact = new HashSet<ContractPartnerSecondaryContact>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid Contract { get; set; }
        public Guid Partner { get; set; }
        public string Sales { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone2 { get; set; }

        public virtual Contract ContractNavigation { get; set; }
        public virtual ContractPartner PartnerNavigation { get; set; }
        public virtual ICollection<ContractPartnerSecondaryContact> ContractPartnerSecondaryContact { get; set; }
    }
}
