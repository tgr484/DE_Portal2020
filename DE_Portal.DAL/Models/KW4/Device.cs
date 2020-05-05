using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Device
    {
        public Device()
        {
            ClientHardwareDevice = new HashSet<ClientHardwareDevice>();
            CustomEscalationProcedureDevices = new HashSet<CustomEscalationProcedureDevices>();
            Dbinstance = new HashSet<Dbinstance>();
            DeviceAgentProxy = new HashSet<DeviceAgentProxy>();
            DeviceAuditItem = new HashSet<DeviceAuditItem>();
            DeviceConfigInfo = new HashSet<DeviceConfigInfo>();
            InvComponentDevice = new HashSet<InvComponentDevice>();
        }

        public int Id { get; set; }
        public int? ConnectedToId { get; set; }
        public string ConnectedPort { get; set; }
        public int DeviceType { get; set; }
        public int ClientId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceRole { get; set; }
        public string Ipaddress { get; set; }
        public string Location { get; set; }
        public int TimeOfServiceId { get; set; }
        public string EscallationProcedure { get; set; }
        public int ReportIcmp { get; set; }
        public int ReportHttp { get; set; }
        public int ReportSql { get; set; }
        public int ReportOracle { get; set; }
        public int ReportMySql { get; set; }
        public int ReportSmtp { get; set; }
        public int ReportFtp { get; set; }
        public int ReportHeartBeat { get; set; }
        public int ReportPerformance { get; set; }
        public int ReportDisks { get; set; }
        public int ReportProcesses { get; set; }
        public int ReportInsidePort { get; set; }
        public int ReportLogs { get; set; }
        public int ReportDbvolumes { get; set; }
        public int ReportSqlfiles { get; set; }
        public int PatchControl { get; set; }
        public DateTime? LastPatchDate { get; set; }
        public int? PatchExpiresIn { get; set; }
        public DateTime Ts { get; set; }
        public int? LastPatchAdmin { get; set; }
        public int IsNotCritical { get; set; }
        public int ReportDns { get; set; }
        public string Host { get; set; }
        public int? OwnerAdmin { get; set; }
        public int ReportTcp { get; set; }
        public string DeagentVersion { get; set; }
        public string NewDeagentVersion { get; set; }
        public string KernelVersion { get; set; }
        public string ProcpsVersion { get; set; }
        public string BashVersion { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string Memory { get; set; }
        public string Uptime { get; set; }
        public int ReportCustomSql { get; set; }
        public int? ReportCustomPerfCounter { get; set; }
        public bool IndicatorPs { get; set; }
        public bool IndicatorNa { get; set; }
        public bool IndicatorHd { get; set; }
        public string Ledlocation { get; set; }
        public int SubdevicesCount { get; set; }
        public string Ipaddresses { get; set; }
        public string Dnsservers { get; set; }
        public int? DeviceMakeId { get; set; }
        public int? OperatingSystemId { get; set; }
        public string HardwareSpecs { get; set; }
        public string BusinessAppsRunning { get; set; }
        public string BusinessAdditionalInfo { get; set; }
        public string BackupProcedure { get; set; }
        public string ConnectionsMapOrigFilename { get; set; }
        public string ConnectionsMapSavedFilename { get; set; }
        public string ManufacturerStatsHard { get; set; }
        public string ManufacturerStatsSoft { get; set; }
        public DateTime? InstallDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? WarrantyExpire { get; set; }
        public string MonitoringCoverage { get; set; }
        public int? MonitoringConsiderationId { get; set; }
        public string HardwareSpecsOrigFilename { get; set; }
        public string HardwareSpecsSavedFilename { get; set; }
        public string DeviceMakeOther { get; set; }
        public string OperatingSystemOther { get; set; }
        public int? ReportNics { get; set; }
        public int? ReportExchange { get; set; }
        public int? SiteId { get; set; }
        public int? ReportFileWatcher { get; set; }
        public string SupportGroup { get; set; }
        public string Description { get; set; }
        public int? ReportReboots { get; set; }
        public string Uuid { get; set; }
        public int? ReportPostgreSql { get; set; }

        public virtual Site Site { get; set; }
        public virtual ICollection<ClientHardwareDevice> ClientHardwareDevice { get; set; }
        public virtual ICollection<CustomEscalationProcedureDevices> CustomEscalationProcedureDevices { get; set; }
        public virtual ICollection<Dbinstance> Dbinstance { get; set; }
        public virtual ICollection<DeviceAgentProxy> DeviceAgentProxy { get; set; }
        public virtual ICollection<DeviceAuditItem> DeviceAuditItem { get; set; }
        public virtual ICollection<DeviceConfigInfo> DeviceConfigInfo { get; set; }
        public virtual ICollection<InvComponentDevice> InvComponentDevice { get; set; }
    }
}
