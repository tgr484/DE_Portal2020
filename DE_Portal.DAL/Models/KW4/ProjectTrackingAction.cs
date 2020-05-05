using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectTrackingAction
    {
        public int Id { get; set; }
        public int SubProjectId { get; set; }
        public string Name { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int PersonResponsibleId { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public int? OrderNumber { get; set; }
        public DateTime Ts { get; set; }
        public int? CreatedUserId { get; set; }
        public string StatusDescription { get; set; }
        public int? Hours { get; set; }
        public string Risk { get; set; }
        public string PossibleImpact { get; set; }

        public virtual Users CreatedUser { get; set; }
    }
}
