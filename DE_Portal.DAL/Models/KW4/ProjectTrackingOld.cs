using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectTrackingOld
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public bool IsProject { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public int? DePmId { get; set; }
        public string ClientPmName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public int StatusAdminId { get; set; }
    }
}
