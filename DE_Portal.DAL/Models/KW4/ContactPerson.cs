using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContactPerson
    {
        public ContactPerson()
        {
            ContactPersonGroup = new HashSet<ContactPersonGroup>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public string Client { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public int Type { get; set; }
        public string Email { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Notes { get; set; }
        public bool Subscribed { get; set; }
        public int UnsubscribeSource { get; set; }

        public virtual ICollection<ContactPersonGroup> ContactPersonGroup { get; set; }
    }
}
