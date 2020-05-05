using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class PartnersPortal
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int ClientId { get; set; }
        public int ClientLoginId { get; set; }
        public string ClientLogin { get; set; }
        public int Status { get; set; }
        public DateTime? DateLastUpdated { get; set; }
        public int? UpdatedUserId { get; set; }
        public string DeclineReason { get; set; }
        public string CompanyName { get; set; }
        public string PrimaryContact { get; set; }
        public string PrimaryContactPhone { get; set; }
        public string PrimaryContactEmail { get; set; }
        public string SecondaryContact { get; set; }
        public string SecondaryContactPhone { get; set; }
        public string SecondaryContactEmail { get; set; }
        public string ServicesRequired { get; set; }
        public string Description { get; set; }
        public string DealLocation { get; set; }
        public DateTime? EstimatedTimeframe { get; set; }
        public string Paid { get; set; }
        public string Closed { get; set; }
    }
}
