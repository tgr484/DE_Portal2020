using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Bpmlog
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string FileName { get; set; }
        public long? Size { get; set; }
        public string Comment { get; set; }
        public string Status { get; set; }
        public DateTime Ts { get; set; }
    }
}
