using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class NewsLetterBlockLink
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid Block { get; set; }
        public DateTime? Visited { get; set; }
        public Guid ContactId { get; set; }

        public virtual NewsLetterBlock BlockNavigation { get; set; }
    }
}
