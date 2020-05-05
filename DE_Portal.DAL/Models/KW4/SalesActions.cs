using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SalesActions
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public DateTime? ActionDate { get; set; }
        public DateTime? NextActionDate { get; set; }
        public int ActionPersonId { get; set; }
        public string FollowUpNotes { get; set; }
    }
}
