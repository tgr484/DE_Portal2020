using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractPartnerSecondaryContact
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid ContractPartner { get; set; }
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

        public virtual ContractPartnerMap ContractPartnerNavigation { get; set; }
    }
}
