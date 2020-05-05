using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketClass
    {
        public TicketClass()
        {
            RecuringTicket = new HashSet<RecuringTicket>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Deadline { get; set; }
        public int? FirstResponseIn { get; set; }
        public int SortOrder { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<RecuringTicket> RecuringTicket { get; set; }
    }
}
