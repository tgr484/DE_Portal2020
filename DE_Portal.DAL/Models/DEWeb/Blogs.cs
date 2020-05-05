using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class Blogs
    {
        public int Id { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public DateTime DatetimeModified { get; set; }
        public DateTime DatetimePublished { get; set; }
        public byte IsPublished { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string ShortText { get; set; }
        public string BlogText { get; set; }
    }
}
