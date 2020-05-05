using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Document
    {
        public Document()
        {
            DocumentVersion = new HashSet<DocumentVersion>();
        }

        public int Id { get; set; }
        public int DocumentCategoryId { get; set; }
        public int? Status { get; set; }

        public virtual DocumentCategory DocumentCategory { get; set; }
        public virtual ICollection<DocumentVersion> DocumentVersion { get; set; }
    }
}
