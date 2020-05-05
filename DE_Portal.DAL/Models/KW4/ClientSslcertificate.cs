using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientSslcertificate
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? DeviceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Active { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? CertificateLastChecked { get; set; }
        public DateTime? CertificateExpiresOn { get; set; }
        public string CertificateName { get; set; }
        public string CertificateIssuer { get; set; }
        public string CertificateSerial { get; set; }
    }
}
