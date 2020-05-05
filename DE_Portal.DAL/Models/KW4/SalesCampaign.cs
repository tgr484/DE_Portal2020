using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SalesCampaign
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserCreated { get; set; }
        public int Status { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public DateTime? Deadline { get; set; }
        public string PreRequisites { get; set; }
    }
}
