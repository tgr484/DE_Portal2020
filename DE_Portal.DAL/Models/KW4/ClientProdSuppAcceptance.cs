using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientProdSuppAcceptance
    {
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UpdatedUserId { get; set; }
        public int? SignoffProdManagerUserId { get; set; }
        public DateTime? AcceptedOn { get; set; }
    }
}
