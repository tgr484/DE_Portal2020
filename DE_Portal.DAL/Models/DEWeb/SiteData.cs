using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class SiteData
    {
        public string SiteDataName { get; set; }
        public string SiteDataData { get; set; }
        public byte[] SiteDataTs { get; set; }
    }
}
