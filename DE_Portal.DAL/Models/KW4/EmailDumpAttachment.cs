using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EmailDumpAttachment
    {
        public int EmailDumpAttachmentId { get; set; }
        public int EmailDumpId { get; set; }
        public string AttachmentName { get; set; }
        public byte[] AttachmentData { get; set; }
        public int? TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
