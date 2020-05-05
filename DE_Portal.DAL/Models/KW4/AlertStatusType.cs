using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class AlertStatusType
    {
        public int Id { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public DateTime Ts { get; set; }
    }
}
