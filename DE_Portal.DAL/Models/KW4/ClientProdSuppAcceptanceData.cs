using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientProdSuppAcceptanceData
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int ClientId { get; set; }
        public int MetaId { get; set; }
        public string InEms { get; set; }
        public int? UserId { get; set; }
        public string Comments { get; set; }
    }
}
