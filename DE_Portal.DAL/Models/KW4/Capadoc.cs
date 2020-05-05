using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Capadoc
    {
        public int Id { get; set; }
        public DateTime DateModified { get; set; }
        public int RevId { get; set; }
        public string SupportingDocName { get; set; }
        public byte[] SupportingDoc { get; set; }
    }
}
