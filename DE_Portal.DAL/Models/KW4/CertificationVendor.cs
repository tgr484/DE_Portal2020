using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CertificationVendor
    {
        public CertificationVendor()
        {
            UserCertification = new HashSet<UserCertification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserCertification> UserCertification { get; set; }
    }
}
