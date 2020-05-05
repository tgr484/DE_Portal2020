using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractPaymentComment
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid? Payment { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public int User { get; set; }

        public virtual ContractPayment PaymentNavigation { get; set; }
        public virtual Users UserNavigation { get; set; }
    }
}
