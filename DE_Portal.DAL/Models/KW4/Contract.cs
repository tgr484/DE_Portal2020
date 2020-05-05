using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Contract
    {
        public Contract()
        {
            ContractDetails = new HashSet<ContractDetails>();
            ContractPartnerMap = new HashSet<ContractPartnerMap>();
        }

        public Guid Id { get; set; }
        public int Client { get; set; }
        public string SubClientOf { get; set; }
        public byte[] Version { get; set; }
        public int StandardReminders { get; set; }
        public bool Archived { get; set; }
        public int DeRep { get; set; }

        public virtual Client ClientNavigation { get; set; }
        public virtual Users DeRepNavigation { get; set; }
        public virtual ICollection<ContractDetails> ContractDetails { get; set; }
        public virtual ICollection<ContractPartnerMap> ContractPartnerMap { get; set; }
    }
}
