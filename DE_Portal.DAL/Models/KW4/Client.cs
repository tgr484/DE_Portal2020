using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Client
    {
        public Client()
        {
            ClientAdministrator = new HashSet<ClientAdministrator>();
            ClientHardware = new HashSet<ClientHardware>();
            ClientLogin = new HashSet<ClientLogin>();
            ClientSite = new HashSet<ClientSite>();
            ClientSoftware = new HashSet<ClientSoftware>();
            ClientVendor = new HashSet<ClientVendor>();
            Contract = new HashSet<Contract>();
            Contract2Party = new HashSet<Contract2Party>();
            DeviceAudit = new HashSet<DeviceAudit>();
            DeviceConfigInfo = new HashSet<DeviceConfigInfo>();
            DiskDestructionLog = new HashSet<DiskDestructionLog>();
            EngineeringTaskStatus = new HashSet<EngineeringTaskStatus>();
            InternalAudit = new HashSet<InternalAudit>();
            InvApplication = new HashSet<InvApplication>();
            MonitoringHistory = new HashSet<MonitoringHistory>();
            PermissionClientLogin = new HashSet<PermissionClientLogin>();
            RecuringTicket = new HashSet<RecuringTicket>();
            ScheduledClientReport = new HashSet<ScheduledClientReport>();
            ProjectTrackingProjects = new HashSet<ProjectTrackingProject>();
        }

        public int Id { get; set; }
        public string ClientName { get; set; }
        public int RelationshipManagerId { get; set; }
        public string EscallationProcedure { get; set; }
        public byte ReportScanResultsDifferences { get; set; }
        public DateTime Ts { get; set; }
        public string EscalationProcedure { get; set; }
        public int MaintMode { get; set; }
        public DateTime? MaintModeStart { get; set; }
        public string CmonEscalationProcedure { get; set; }
        public string ClientKey { get; set; }
        public int PortalMenuMask { get; set; }
        public string ScopeOfService { get; set; }
        public string Itservices { get; set; }
        public string SoftwareInfo { get; set; }
        public string BackupRecoveryInfo { get; set; }
        public string PasswordInfo { get; set; }
        public int? SendAutoAlertNotifications { get; set; }
        public string AlertNotificationsRecipients { get; set; }
        public string ReportPrefix { get; set; }
        public bool Deleted { get; set; }
        public string Sla { get; set; }
        public string ClientEscalationProcedure { get; set; }
        public string DeviceAuditClientName { get; set; }
        public string DeviceAuditStreet { get; set; }
        public string DeviceAuditCity { get; set; }
        public string DeviceAuditState { get; set; }
        public string DeviceAuditZip { get; set; }
        public string DeviceAuditPhone { get; set; }
        public string DeviceAuditFax { get; set; }
        public string DeviceAuditWebsite { get; set; }
        public string DeviceAuditEmail { get; set; }
        public string EscalationProcedureUpdated { get; set; }

        public virtual ICollection<ProjectTrackingProject> ProjectTrackingProjects {get; set;}
        public virtual ICollection<ClientAdministrator> ClientAdministrator { get; set; }
        public virtual ICollection<ClientHardware> ClientHardware { get; set; }
        public virtual ICollection<ClientLogin> ClientLogin { get; set; }
        public virtual ICollection<ClientSite> ClientSite { get; set; }
        public virtual ICollection<ClientSoftware> ClientSoftware { get; set; }
        public virtual ICollection<ClientVendor> ClientVendor { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<Contract2Party> Contract2Party { get; set; }
        public virtual ICollection<DeviceAudit> DeviceAudit { get; set; }
        public virtual ICollection<DeviceConfigInfo> DeviceConfigInfo { get; set; }
        public virtual ICollection<DiskDestructionLog> DiskDestructionLog { get; set; }
        public virtual ICollection<EngineeringTaskStatus> EngineeringTaskStatus { get; set; }
        public virtual ICollection<InternalAudit> InternalAudit { get; set; }
        public virtual ICollection<InvApplication> InvApplication { get; set; }
        public virtual ICollection<MonitoringHistory> MonitoringHistory { get; set; }
        public virtual ICollection<PermissionClientLogin> PermissionClientLogin { get; set; }
        public virtual ICollection<RecuringTicket> RecuringTicket { get; set; }
        public virtual ICollection<ScheduledClientReport> ScheduledClientReport { get; set; }
    }
}
