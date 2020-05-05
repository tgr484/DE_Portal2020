using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class VClientsExceptRumc
    {
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
    }
}
