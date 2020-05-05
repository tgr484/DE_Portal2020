using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectNotes
    {
        public int Id { get; set; }
        public int ProjectTrackingId { get; set; }
        public string Content { get; set; }
        public DateTime? Ts { get; set; }
        public int UserId { get; set; }
    }
}
