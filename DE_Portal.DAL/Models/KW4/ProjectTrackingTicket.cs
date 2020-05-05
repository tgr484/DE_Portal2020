using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectTrackingTicket
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectType { get; set; }
    }
}
