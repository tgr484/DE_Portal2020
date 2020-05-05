using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CustomMonitoring
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public int? AssetId { get; set; }
        public string EmailFrom { get; set; }
        public string EmailTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int? Status { get; set; }
        public DateTime Ts { get; set; }
    }
}
