using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SalesDailyPlan
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int OwnerId { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public int? Priority { get; set; }
        public int Status { get; set; }
        public DateTime? DateFinished { get; set; }
        public int? SaleId { get; set; }
        public int? SubprojectId { get; set; }
        public int? ProjectActionId { get; set; }
        public int? Sort { get; set; }
        public int? AssignedTo { get; set; }
        public string Notes { get; set; }
        public int? IsOutstanding { get; set; }
    }
}
