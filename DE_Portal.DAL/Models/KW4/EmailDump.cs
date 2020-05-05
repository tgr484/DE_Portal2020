using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EmailDump
    {
        public int EmailDumpId { get; set; }
        public string MessageId { get; set; }
        public string From { get; set; }
        public string ReplyTo { get; set; }
        public string Sender { get; set; }
        public string To { get; set; }
        public string Cc { get; set; }
        public string Bcc { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string BodyFormat { get; set; }
        public string TextBody { get; set; }
        public DateTime? Date { get; set; }
        public string Priority { get; set; }
        public int? TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }
    }
}
