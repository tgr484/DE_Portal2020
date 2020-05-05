using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SalesPartnerLeadContact
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int SalesPartnerId { get; set; }
        public int UserId { get; set; }
        public byte? IsContact { get; set; }
        public byte? IsLead { get; set; }
        public string Notes { get; set; }
    }
}
