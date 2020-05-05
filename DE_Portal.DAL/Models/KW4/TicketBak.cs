using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketBak
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int StatusAdminId { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string EmailFrom { get; set; }
        public string Tid { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string AdminNotes { get; set; }
        public DateTime Ts { get; set; }
        public int? ClientId { get; set; }
        public double? HoursSpent { get; set; }
        public string Resolution { get; set; }
        public int ImplementationFlag { get; set; }
        public DateTime? Deadline { get; set; }
        public int TypeId { get; set; }
        public int? AssignedTo { get; set; }
        public int AssignedBy { get; set; }
        public string History { get; set; }
        public bool AtThatTime { get; set; }
        public int Priority { get; set; }
        public string ClientTicketId { get; set; }
        public int? ParentTicketId { get; set; }
        public DateTime? StartDate { get; set; }
        public int? Class { get; set; }
        public Guid TicketId { get; set; }
        public bool StatusUpdateSent { get; set; }
        public Guid TicketRoid { get; set; }
        public string EmailTo { get; set; }
    }
}
