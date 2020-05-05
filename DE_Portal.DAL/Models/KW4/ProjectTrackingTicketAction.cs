using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectTrackingTicketAction
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int ActionId { get; set; }
    }
}
