using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Sales
    {
        public int Id { get; set; }
        public string PotentialName { get; set; }
        public int ClientId { get; set; }
        public string Referral { get; set; }
        public int RelationshipManagerId { get; set; }
        public string Description { get; set; }
        public string NextFollowUp { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public int StatusId { get; set; }
        public int PaymentType { get; set; }
        public int SalesProductId { get; set; }
        public string PlannedRevenue { get; set; }
        public DateTime Ts { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string SecondaryPhone { get; set; }
        public string Person { get; set; }
        public int ExistingClient { get; set; }
        public string Email { get; set; }
        public bool HighPriority { get; set; }
        public int? CreatorId { get; set; }
        public int SubStatus { get; set; }
        public string OpportunityType { get; set; }
        public string SalesTeam { get; set; }
        public int? SalesCampaignId { get; set; }
        public int? SalesCampaignOwnerUserId { get; set; }
        public int? FrontRunnerUserId { get; set; }
        public int? SalesEngineerUserId { get; set; }
        public int? SalesManagerUserId { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonLastName { get; set; }
        public string JobTitle { get; set; }
    }
}
