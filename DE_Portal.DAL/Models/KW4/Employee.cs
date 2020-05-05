using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneOffice { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneCell { get; set; }
        public string Department { get; set; }
        public int? VcardAttachmentId { get; set; }
    }
}
