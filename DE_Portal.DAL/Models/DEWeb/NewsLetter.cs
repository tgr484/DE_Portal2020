using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class NewsLetter
    {
        public NewsLetter()
        {
            NewsLetterBlock = new HashSet<NewsLetterBlock>();
            NewsLetterGroup = new HashSet<NewsLetterGroup>();
            NewsLetterUnsubscribe = new HashSet<NewsLetterUnsubscribe>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public string Title { get; set; }
        public bool? ShowOnSite { get; set; }
        public bool? Draft { get; set; }
        public Guid? TestGroupId { get; set; }
        public string TitleColor { get; set; }
        public string LetterSubTitle { get; set; }

        public virtual ICollection<NewsLetterBlock> NewsLetterBlock { get; set; }
        public virtual ICollection<NewsLetterGroup> NewsLetterGroup { get; set; }
        public virtual ICollection<NewsLetterUnsubscribe> NewsLetterUnsubscribe { get; set; }
    }
}
