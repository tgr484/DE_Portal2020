using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CertificationStatus
    {
        public CertificationStatus()
        {
            UserCertification = new HashSet<UserCertification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<UserCertification> UserCertification { get; set; }
    }
}
