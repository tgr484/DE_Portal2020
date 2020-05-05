using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractReminder
    {
        public Guid Id { get; set; }
        public Guid Details { get; set; }
        public int Days { get; set; }
        public bool NotificationSent { get; set; }
        public byte[] Version { get; set; }
        public string Recipients { get; set; }

        public virtual ContractDetails DetailsNavigation { get; set; }
    }
}
