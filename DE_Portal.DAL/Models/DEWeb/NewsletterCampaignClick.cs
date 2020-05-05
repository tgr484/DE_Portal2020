using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class NewsletterCampaignClick
    {
        public int Id { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public string Campaign { get; set; }
        public string ClickedCid { get; set; }
        public string ClickedLink { get; set; }
        public string UserAgent { get; set; }
        public byte CampaignRegistered { get; set; }
        public string CampaignCid { get; set; }
        public string CampaignName { get; set; }
        public string CampaignPhone { get; set; }
        public string CampaignCompany { get; set; }
        public string CampaignEmail { get; set; }
        public byte? CampaignOption1 { get; set; }
        public byte? CampaignOption2 { get; set; }
        public byte? CampaignOption3 { get; set; }
        public byte? CampaignOption4 { get; set; }
        public byte? CampaignOption5 { get; set; }
        public byte? CampaignOption6 { get; set; }
        public byte? CampaignOption7 { get; set; }
        public byte? CampaignOption8 { get; set; }
    }
}
