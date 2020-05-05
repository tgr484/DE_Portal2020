using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class NewsLetterUnsubscribe
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid NewsLetter { get; set; }
        public Guid ContactId { get; set; }
        public DateTime? Date { get; set; }

        public virtual NewsLetter NewsLetterNavigation { get; set; }
    }
}
