using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Caparev
    {
        public int Id { get; set; }
        public DateTime DateModified { get; set; }
        public int RevId { get; set; }
        public int Status { get; set; }
        public string StatusUpdateMessage { get; set; }
        public int UserModified { get; set; }
        public int? VerifiedBy { get; set; }
    }
}
