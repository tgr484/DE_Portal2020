using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SalesCampaignActivity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int SalesCampaignId { get; set; }
        public int UserId { get; set; }
        public int Calls { get; set; }
        public int Leads { get; set; }
    }
}
