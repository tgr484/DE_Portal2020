using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class AttachmentSet
    {
        public AttachmentSet()
        {
            Attachment = new HashSet<Attachment>();
            ClientVendor = new HashSet<ClientVendor>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? OwnerId { get; set; }

        public virtual ICollection<Attachment> Attachment { get; set; }
        public virtual ICollection<ClientVendor> ClientVendor { get; set; }
    }
}
