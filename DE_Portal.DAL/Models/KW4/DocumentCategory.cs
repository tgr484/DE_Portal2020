using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DocumentCategory
    {
        public DocumentCategory()
        {
            Document = new HashSet<Document>();
            InverseDocumentCategoryNavigation = new HashSet<DocumentCategory>();
        }

        public int Id { get; set; }
        public int? DocumentCategoryId { get; set; }
        public string Title { get; set; }

        public virtual DocumentCategory DocumentCategoryNavigation { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<DocumentCategory> InverseDocumentCategoryNavigation { get; set; }
    }
}
