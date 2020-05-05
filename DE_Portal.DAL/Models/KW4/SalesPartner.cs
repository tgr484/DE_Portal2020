using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SalesPartner
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int IsVisible { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? RespUserId { get; set; }
        public int? Contacts { get; set; }
        public int? Leads { get; set; }
        public DateTime? LastContactDate { get; set; }
        public int? LastContactUserId { get; set; }
    }
}
