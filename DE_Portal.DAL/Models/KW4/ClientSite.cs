using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientSite
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int SiteId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Site Site { get; set; }
    }
}
