using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Attachment
    {
        public int Id { get; set; }
        public int? SetId { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string AuthorizedRoles { get; set; }
        public byte[] File { get; set; }

        public virtual AttachmentSet Set { get; set; }
    }
}
