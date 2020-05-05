using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class VSatisfactionReport
    {
        public int? Year { get; set; }
        public string Month { get; set; }
        public string SatisfactionStatus { get; set; }
        public string Reopened { get; set; }
        public int? TicketCount { get; set; }
    }
}
