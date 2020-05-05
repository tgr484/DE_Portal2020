using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Cabrev
    {
        public int Id { get; set; }
        public DateTime DateModified { get; set; }
        public int RevId { get; set; }
        public string StatusUpdateMessage { get; set; }
        public int UserModified { get; set; }
    }
}
