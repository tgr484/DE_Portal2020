using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class RecuringTicketInstance
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid RecuringTicket { get; set; }
        public int Ticket { get; set; }
        public DateTime Created { get; set; }

        public virtual RecuringTicket RecuringTicketNavigation { get; set; }
        public virtual Ticket TicketNavigation { get; set; }
    }
}
