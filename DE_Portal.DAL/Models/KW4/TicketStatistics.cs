using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketStatistics
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Overdue { get; set; }
        public int PendingOverdue { get; set; }
        public int Pending { get; set; }
    }
}
