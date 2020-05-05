using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class NewsLetterBlock
    {
        public NewsLetterBlock()
        {
            NewsLetterBlockLink = new HashSet<NewsLetterBlockLink>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public int Rank { get; set; }
        public string Title { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public Guid NewsLetter { get; set; }
        public bool CustomShort { get; set; }
        public bool PreviewAsBody { get; set; }
        public bool RemoveTitle { get; set; }

        public virtual NewsLetter NewsLetterNavigation { get; set; }
        public virtual ICollection<NewsLetterBlockLink> NewsLetterBlockLink { get; set; }
    }
}
