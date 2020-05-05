using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class RecuringTicket
    {
        public RecuringTicket()
        {
            RecuringTicketInstance = new HashSet<RecuringTicketInstance>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public int Type { get; set; }
        public int Class { get; set; }
        public int Client { get; set; }
        public string From { get; set; }
        public string Cc { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int Creator { get; set; }
        public int? Executor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int GenerateTime { get; set; }
        public string Schedule { get; set; }
        public bool Active { get; set; }
        public int UserId { get; set; }

        public virtual TicketClass ClassNavigation { get; set; }
        public virtual Client ClientNavigation { get; set; }
        public virtual Users CreatorNavigation { get; set; }
        public virtual Users ExecutorNavigation { get; set; }
        public virtual ICollection<RecuringTicketInstance> RecuringTicketInstance { get; set; }
    }
}
