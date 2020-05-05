using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class SiteContent
    {
        public int SiteContentId { get; set; }
        public string SiteContentPath { get; set; }
        public string SiteContentTitle { get; set; }
        public string SiteContentContent { get; set; }
        public string SiteContentName { get; set; }
        public string SiteContentLocation { get; set; }
        public bool SiteContentClear { get; set; }
        public string SiteReusablePartsName { get; set; }
    }
}
