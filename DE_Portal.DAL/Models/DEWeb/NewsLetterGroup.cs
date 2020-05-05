using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class NewsLetterGroup
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid NewsLetter { get; set; }
        public Guid GroupId { get; set; }
        public DateTime Date { get; set; }
        public bool Processed { get; set; }

        public virtual NewsLetter NewsLetterNavigation { get; set; }
    }
}
