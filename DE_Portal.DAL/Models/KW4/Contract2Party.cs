using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Contract2Party
    {
        public Contract2Party()
        {
            Contract2ClientNavigation = new HashSet<Contract2>();
            Contract2PartnerNavigation = new HashSet<Contract2>();
            Contract2VendorNavigation = new HashSet<Contract2>();
        }

        public int Id { get; set; }
        public byte[] Version { get; set; }
        public int Type { get; set; }
        public int? Client { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string ContactInfo { get; set; }

        public virtual Client ClientNavigation { get; set; }
        public virtual ICollection<Contract2> Contract2ClientNavigation { get; set; }
        public virtual ICollection<Contract2> Contract2PartnerNavigation { get; set; }
        public virtual ICollection<Contract2> Contract2VendorNavigation { get; set; }
    }
}
