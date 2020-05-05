using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DocumentVersion
    {
        public DocumentVersion()
        {
            DocumentRecipient = new HashSet<DocumentRecipient>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public int DocumentId { get; set; }
        public string Description { get; set; }
        public int? DocumentFileId { get; set; }
        public int Version { get; set; }

        public virtual Users CreatedUser { get; set; }
        public virtual Document Document { get; set; }
        public virtual ICollection<DocumentRecipient> DocumentRecipient { get; set; }
    }
}
