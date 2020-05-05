using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContactPersonGroup
    {
        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid Person { get; set; }
        public Guid Group { get; set; }

        public virtual ContactGroup GroupNavigation { get; set; }
        public virtual ContactPerson PersonNavigation { get; set; }
    }
}
