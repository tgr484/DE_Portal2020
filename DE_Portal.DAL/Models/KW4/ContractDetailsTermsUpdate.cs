using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractDetailsTermsUpdate
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid Details { get; set; }
        public int User { get; set; }
        public DateTime Date { get; set; }
        public string Update { get; set; }

        public virtual ContractDetails DetailsNavigation { get; set; }
        public virtual Users UserNavigation { get; set; }
    }
}
