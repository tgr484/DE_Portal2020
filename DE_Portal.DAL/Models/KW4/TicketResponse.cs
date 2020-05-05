using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketResponse
    {
        public TicketResponse()
        {
            TicketResponseAttachmentTest = new HashSet<TicketResponseAttachmentTest>();
        }

        public Guid Id { get; set; }
        public int TicketId { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }
        public DateTime? Timestamp { get; set; }
        public int? User { get; set; }
        public Guid? ChangeSet { get; set; }
        public int Source { get; set; }
        public bool Acknowledged { get; set; }
        public int? AcknowledgedBy { get; set; }
        public DateTime? AcknowledgedOn { get; set; }
        public string ClientResponseId { get; set; }
        public int? PortalUserId { get; set; }

        public virtual Ticket Ticket { get; set; }
        public virtual Users UserNavigation { get; set; }
        public virtual ICollection<TicketResponseAttachmentTest> TicketResponseAttachmentTest { get; set; }
    }
}
