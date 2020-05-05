using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int ClientId { get; set; }
        public string Description { get; set; }
        public int AssignedBy { get; set; }
        public int AssignedTo { get; set; }
        public int StatusId { get; set; }
        public DateTime? DeadLine { get; set; }
        public DateTime Created { get; set; }
        public string ClosingNotes { get; set; }
        public double? HoursSpent { get; set; }
        public int? UpdateClosingNotes { get; set; }
        public int? UpdateHoursSpent { get; set; }
    }
}
