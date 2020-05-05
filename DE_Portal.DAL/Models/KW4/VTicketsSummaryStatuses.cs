using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class VTicketsSummaryStatuses
    {
        public int? ClientId { get; set; }
        public DateTime? OpenDate { get; set; }
        public int? Tickets1 { get; set; }
        public int? Tickets2 { get; set; }
        public int? Tickets8 { get; set; }
        public int? Tickets4 { get; set; }
        public int? Tickets9 { get; set; }
        public int? Tickets3 { get; set; }
        public int? TicketsExcelent { get; set; }
        public int? TicketsSatisfied { get; set; }
        public int? TicketsNotSatisfied { get; set; }
        public int? TicketsReopened { get; set; }
    }
}
