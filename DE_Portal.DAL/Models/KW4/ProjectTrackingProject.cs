using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectTrackingProject
    {
        public ProjectTrackingProject()
        {
            EngineeringTaskStatus = new HashSet<EngineeringTaskStatus>();
            ProjectResourceActual = new HashSet<ProjectResourceActual>();
            ProjectResourcePlanning = new HashSet<ProjectResourcePlanning>();
            ProjectTrackingProjectStatementOfCompletionFile = new HashSet<ProjectTrackingProjectStatementOfCompletionFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }

        public Client Client { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int PersonResponsibleId { get; set; }

        public DE_Portal.DAL.Models.KW4.Users Am { get; set; } 
        public string Description { get; set; }
        public bool Done { get; set; }
        public int? ApprovedBy { get; set; }
        public DE_Portal.DAL.Models.KW4.Users Tl { get; set; }
        public string HardWare { get; set; }
        public string SoftWare { get; set; }
        public byte[] Architecture { get; set; }
        public bool IsProjectManagement { get; set; }
        public bool IsMigration { get; set; }
        public bool IsInstallations { get; set; }
        public bool IsSetupConfigurations { get; set; }
        public bool IsTesting { get; set; }
        public string Attn { get; set; }
        public int? Overseer { get; set; }
        public DE_Portal.DAL.Models.KW4.Users Os { get; set; }

        public DateTime? ConfirmDate { get; set; }
        public bool IsHardDate { get; set; }
        public bool HasToBeConfirmByClient { get; set; }
        public bool IsInternallyProject { get; set; }
        public string CloseNotificationOs { get; set; }
        public string CloseNotificationPm { get; set; }
        public int Status { get; set; }
        public bool ApprovedByOs { get; set; }
        public bool ApprovedByPm { get; set; }
        public bool ApprovedByTl { get; set; }
        public bool ClosedByOs { get; set; }
        public bool ClosedByPm { get; set; }
        public DateTime Ts { get; set; }
        public bool? IsHardDeliveryDate { get; set; }
        public bool? HasToBeConfirmByClientDeliveryDate { get; set; }
        public bool IsKnowledgeAssistance { get; set; }
        public string Details { get; set; }
        public bool IsImplementationOther { get; set; }
        public string ImplementationOther { get; set; }
        public string LocationOther { get; set; }
        public bool IsLocationOther { get; set; }
        public string ResourcesColor { get; set; }
        public string OnScheduleColor { get; set; }
        public string StatusColor { get; set; }
        public int? ProjectTrackingTypeId { get; set; }
        public int? Hours { get; set; }
        public string SecurityNotes { get; set; }
        public bool StatementOfCompletionNeeded { get; set; }
        public int? ProjectTrackingKind { get; set; }

        public virtual ICollection<EngineeringTaskStatus> EngineeringTaskStatus { get; set; }
        public virtual ICollection<ProjectResourceActual> ProjectResourceActual { get; set; }
        public virtual ICollection<ProjectResourcePlanning> ProjectResourcePlanning { get; set; }
        public virtual ICollection<ProjectTrackingProjectStatementOfCompletionFile> ProjectTrackingProjectStatementOfCompletionFile { get; set; }
    }
}
