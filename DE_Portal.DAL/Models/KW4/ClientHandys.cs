using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientHandys
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string OsVersion { get; set; }
        public string Imei { get; set; }
        public int? PortalUserId { get; set; }
        public string Token { get; set; }
    }
}
