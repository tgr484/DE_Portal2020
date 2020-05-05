using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketTlacknowledge
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public int TicketId { get; set; }
        public Guid? TicketResponseId { get; set; }
        public Guid? TicketChangesetId { get; set; }
        public int? AcknowledgedBy { get; set; }
        public DateTime? AcknowledgedOn { get; set; }
        public byte? HiddenTicket { get; set; }
    }
}
