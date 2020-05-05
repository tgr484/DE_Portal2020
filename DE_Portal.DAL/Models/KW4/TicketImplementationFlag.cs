using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketImplementationFlag
    {
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public bool? Active { get; set; }
        public int Id { get; set; }
    }
}
