using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Users
    {
        public Users()
        {
            Cabrecords = new HashSet<Cabrecords>();
            Contract = new HashSet<Contract>();
            ContractDetails = new HashSet<ContractDetails>();
            ContractDetailsComment = new HashSet<ContractDetailsComment>();
            ContractDetailsTermsUpdate = new HashSet<ContractDetailsTermsUpdate>();
            ContractPaymentComment = new HashSet<ContractPaymentComment>();
            CustomEscalationProcedureNotificationEmailOslist = new HashSet<CustomEscalationProcedureNotificationEmailOslist>();
            CustomEscalationProceduresProcedureCreatorNavigation = new HashSet<CustomEscalationProcedures>();
            CustomEscalationProceduresProcedureReviewerNavigation = new HashSet<CustomEscalationProcedures>();
            DeviceAuditCreatedUser = new HashSet<DeviceAudit>();
            DeviceAuditFollowUp = new HashSet<DeviceAuditFollowUp>();
            DeviceAuditLastModifiedUser = new HashSet<DeviceAudit>();
            DeviceConfig = new HashSet<DeviceConfig>();
            DeviceConfigHistory = new HashSet<DeviceConfigHistory>();
            DeviceConfigInfoCreatedByNavigation = new HashSet<DeviceConfigInfo>();
            DeviceConfigInfoUpdatedByNavigation = new HashSet<DeviceConfigInfo>();
            DiskDestructionLogCreatedUser = new HashSet<DiskDestructionLog>();
            DiskDestructionLogDestroyedByUser = new HashSet<DiskDestructionLog>();
            DocumentRecipient = new HashSet<DocumentRecipient>();
            DocumentVersion = new HashSet<DocumentVersion>();
            DutyRotation = new HashSet<DutyRotation>();
            EscalationProcedureStatisticsHistoryCreatorNavigation = new HashSet<EscalationProcedureStatisticsHistory>();
            EscalationProcedureStatisticsHistoryReviewerNavigation = new HashSet<EscalationProcedureStatisticsHistory>();
            EscalationProcedureStatisticsOverseers = new HashSet<EscalationProcedureStatisticsOverseers>();
            EscalationProcedureStatisticsProcedureCreators = new HashSet<EscalationProcedureStatisticsProcedureCreators>();
            NetworkMaps = new HashSet<NetworkMaps>();
            ProjectResourceActual = new HashSet<ProjectResourceActual>();
            ProjectResourcePlanningPlannedByUser = new HashSet<ProjectResourcePlanning>();
            ProjectResourcePlanningPlannedForUser = new HashSet<ProjectResourcePlanning>();
            ProjectTrackingAction = new HashSet<ProjectTrackingAction>();
            ProjectTrackingSubProject = new HashSet<ProjectTrackingSubProject>();
            RecuringTicketCreatorNavigation = new HashSet<RecuringTicket>();
            RecuringTicketExecutorNavigation = new HashSet<RecuringTicket>();
            ThreatChangeLog = new HashSet<ThreatChangeLog>();
            ThreatControlOwnerNavigation = new HashSet<Threat>();
            ThreatCreatedUser = new HashSet<Threat>();
            ThreatOwnerUser = new HashSet<Threat>();
            ThreatReview = new HashSet<ThreatReview>();
            ThreatReviewChangeLog = new HashSet<ThreatReviewChangeLog>();
            TicketChangeSet = new HashSet<TicketChangeSet>();
            TicketPriority = new HashSet<TicketPriority>();
            TicketResponse = new HashSet<TicketResponse>();
            UserCertification = new HashSet<UserCertification>();
            Am = new HashSet<ProjectTrackingProject>();
            Os = new HashSet<ProjectTrackingProject>();
            Tl = new HashSet<ProjectTrackingProject>();
        }

        public int Id { get; set; }
        public string Uid { get; set; }
        public string Email { get; set; }
        public int IsAdmin { get; set; }
        public int IsDev { get; set; }
        public DateTime Ts { get; set; }
        public int IsMonitorer { get; set; }
        public int IsSale { get; set; }
        public byte[] BPwd { get; set; }
        public int? IsNotGettingKwalerts { get; set; }
        public int SentEmail { get; set; }
        public string DomainName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Name { get => FirstName + " " + LastName; }
        public DateTime? HireDate { get; set; }
        public string Phone { get; set; }
        public int? IsShift { get; set; }
        public int IsAudit { get; set; }
        public int IsAccountManager { get; set; }
        public int IsTechnicalLead { get; set; }
        public int IsOverseer { get; set; }
        public int? HasDailyPlan { get; set; }
        public int? IsPartnerManager { get; set; }
        public int? IsCampaignParticipant { get; set; }
        public int? HasSalesDailyPlan { get; set; }
        public string Vpnphone { get; set; }
        public string Vpnkeyword { get; set; }
        public int? IsDocumentsAdmin { get; set; }
        public int? CanAssignTickets { get; set; }
        public int ViewIncidents { get; set; }
        public int? ReportsAccessDev { get; set; }
        public int? ReportsAccessOps { get; set; }
        public int? ReportsAccessProj { get; set; }

        public virtual ICollection<Cabrecords> Cabrecords { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<ContractDetails> ContractDetails { get; set; }
        public virtual ICollection<ContractDetailsComment> ContractDetailsComment { get; set; }
        public virtual ICollection<ContractDetailsTermsUpdate> ContractDetailsTermsUpdate { get; set; }
        public virtual ICollection<ContractPaymentComment> ContractPaymentComment { get; set; }
        public virtual ICollection<CustomEscalationProcedureNotificationEmailOslist> CustomEscalationProcedureNotificationEmailOslist { get; set; }
        public virtual ICollection<CustomEscalationProcedures> CustomEscalationProceduresProcedureCreatorNavigation { get; set; }
        public virtual ICollection<CustomEscalationProcedures> CustomEscalationProceduresProcedureReviewerNavigation { get; set; }
        public virtual ICollection<DeviceAudit> DeviceAuditCreatedUser { get; set; }
        public virtual ICollection<DeviceAuditFollowUp> DeviceAuditFollowUp { get; set; }
        public virtual ICollection<DeviceAudit> DeviceAuditLastModifiedUser { get; set; }
        public virtual ICollection<DeviceConfig> DeviceConfig { get; set; }
        public virtual ICollection<DeviceConfigHistory> DeviceConfigHistory { get; set; }
        public virtual ICollection<DeviceConfigInfo> DeviceConfigInfoCreatedByNavigation { get; set; }
        public virtual ICollection<DeviceConfigInfo> DeviceConfigInfoUpdatedByNavigation { get; set; }
        public virtual ICollection<DiskDestructionLog> DiskDestructionLogCreatedUser { get; set; }
        public virtual ICollection<DiskDestructionLog> DiskDestructionLogDestroyedByUser { get; set; }
        public virtual ICollection<DocumentRecipient> DocumentRecipient { get; set; }
        public virtual ICollection<DocumentVersion> DocumentVersion { get; set; }
        public virtual ICollection<DutyRotation> DutyRotation { get; set; }
        public virtual ICollection<EscalationProcedureStatisticsHistory> EscalationProcedureStatisticsHistoryCreatorNavigation { get; set; }
        public virtual ICollection<EscalationProcedureStatisticsHistory> EscalationProcedureStatisticsHistoryReviewerNavigation { get; set; }
        public virtual ICollection<EscalationProcedureStatisticsOverseers> EscalationProcedureStatisticsOverseers { get; set; }
        public virtual ICollection<EscalationProcedureStatisticsProcedureCreators> EscalationProcedureStatisticsProcedureCreators { get; set; }
        public virtual ICollection<NetworkMaps> NetworkMaps { get; set; }
        public virtual ICollection<ProjectResourceActual> ProjectResourceActual { get; set; }
        public virtual ICollection<ProjectResourcePlanning> ProjectResourcePlanningPlannedByUser { get; set; }
        public virtual ICollection<ProjectResourcePlanning> ProjectResourcePlanningPlannedForUser { get; set; }
        public virtual ICollection<ProjectTrackingAction> ProjectTrackingAction { get; set; }
        public virtual ICollection<ProjectTrackingSubProject> ProjectTrackingSubProject { get; set; }
        public virtual ICollection<RecuringTicket> RecuringTicketCreatorNavigation { get; set; }
        public virtual ICollection<RecuringTicket> RecuringTicketExecutorNavigation { get; set; }
        public virtual ICollection<ThreatChangeLog> ThreatChangeLog { get; set; }
        public virtual ICollection<Threat> ThreatControlOwnerNavigation { get; set; }
        public virtual ICollection<Threat> ThreatCreatedUser { get; set; }
        public virtual ICollection<Threat> ThreatOwnerUser { get; set; }
        public virtual ICollection<ThreatReview> ThreatReview { get; set; }
        public virtual ICollection<ThreatReviewChangeLog> ThreatReviewChangeLog { get; set; }
        public virtual ICollection<TicketChangeSet> TicketChangeSet { get; set; }
        public virtual ICollection<TicketPriority> TicketPriority { get; set; }
        public virtual ICollection<TicketResponse> TicketResponse { get; set; }
        public virtual ICollection<UserCertification> UserCertification { get; set; }

        public virtual ICollection<ProjectTrackingProject> Am { get; set; }
        public virtual ICollection<ProjectTrackingProject> Tl { get; set; }
        public virtual ICollection<ProjectTrackingProject> Os { get; set; }


    }
}
