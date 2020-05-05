using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketPriority
    {
        public int UserId { get; set; }
        public int TicketId { get; set; }
        public int Priority { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual Users User { get; set; }
    }
}
