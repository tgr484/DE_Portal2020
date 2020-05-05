using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Rumccalls
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public string Ticket { get; set; }
        public int Operator { get; set; }

        public virtual RumccallsStatus StatusNavigation { get; set; }
    }
}
