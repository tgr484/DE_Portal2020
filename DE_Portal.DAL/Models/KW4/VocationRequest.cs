using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class VocationRequest
    {
        public int Id { get; set; }
        public int? Uid { get; set; }
        public DateTime? DateFrom { get; set; }
        public byte? TimeFrom { get; set; }
        public DateTime DateTo { get; set; }
        public byte? TimeTo { get; set; }
        public int TotalHours { get; set; }
        public int TypeOfVocation { get; set; }
        public string Reason { get; set; }
        public string Comments { get; set; }
        public bool? Accept { get; set; }
        public DateTime Ts { get; set; }
    }
}
