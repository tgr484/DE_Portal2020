using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DocumentRecipient
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DocumentVersionId { get; set; }
        public DateTime? OpenedDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }

        public virtual DocumentVersion DocumentVersion { get; set; }
        public virtual Users User { get; set; }
    }
}
