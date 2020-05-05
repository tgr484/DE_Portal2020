using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketChangeSet
    {
        public TicketChangeSet()
        {
            TicketField = new HashSet<TicketField>();
        }

        public Guid Id { get; set; }
        public int Ticket { get; set; }
        public int User { get; set; }
        public DateTime Timestamp { get; set; }
        public string Comment { get; set; }
        public byte[] Version { get; set; }

        public virtual Ticket TicketNavigation { get; set; }
        public virtual Users UserNavigation { get; set; }
        public virtual ICollection<TicketField> TicketField { get; set; }
    }
}
