using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketField
    {
        public Guid Id { get; set; }
        public Guid ChangeSet { get; set; }
        public string Name { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public byte[] Version { get; set; }

        public virtual TicketChangeSet ChangeSetNavigation { get; set; }
    }
}
