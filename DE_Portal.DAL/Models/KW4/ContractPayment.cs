using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractPayment
    {
        public ContractPayment()
        {
            ContractPaymentComment = new HashSet<ContractPaymentComment>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid ContractDetails { get; set; }
        public int PaymentType { get; set; }
        public string Quote { get; set; }
        public string Po { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Recipient { get; set; }
        public Guid? PartnerId { get; set; }
        public int PaymentDocType { get; set; }
        public string Number { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LastNotified { get; set; }

        public virtual ContractDetails ContractDetailsNavigation { get; set; }
        public virtual ICollection<ContractPaymentComment> ContractPaymentComment { get; set; }
    }
}
