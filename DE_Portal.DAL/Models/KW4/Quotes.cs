using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Quotes
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string DocumentName { get; set; }
        public byte[] Document { get; set; }
        public string Quoteno { get; set; }
        public string Status { get; set; }
        public string UploadedBy { get; set; }
        public string UploadedOn { get; set; }
        public string LastUpdatedBy { get; set; }
        public string LastUpdatedOn { get; set; }
    }
}
