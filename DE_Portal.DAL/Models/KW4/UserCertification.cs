using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class UserCertification
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int VendorId { get; set; }
        public bool IsRequired { get; set; }
        public int? StatusId { get; set; }
        public DateTime Ts { get; set; }

        public virtual CertificationStatus Status { get; set; }
        public virtual Users User { get; set; }
        public virtual CertificationVendor Vendor { get; set; }
    }
}
