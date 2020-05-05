using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContactGroup
    {
        public ContactGroup()
        {
            ContactPersonGroup = new HashSet<ContactPersonGroup>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ContactPersonGroup> ContactPersonGroup { get; set; }
    }
}
