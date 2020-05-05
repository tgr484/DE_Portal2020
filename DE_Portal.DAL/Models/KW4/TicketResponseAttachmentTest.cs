using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketResponseAttachmentTest
    {
        public Guid Id { get; set; }
        public Guid ResponseId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public byte[] Content { get; set; }

        public virtual TicketResponse Response { get; set; }
    }
}
