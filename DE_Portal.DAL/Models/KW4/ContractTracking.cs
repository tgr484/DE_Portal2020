using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractTracking
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public int Service { get; set; }
        public string Number { get; set; }
        public Guid? Details { get; set; }

        public virtual ContractDetails DetailsNavigation { get; set; }
    }
}
