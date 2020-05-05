using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class KW4_Context : DbContext
    {
        public KW4_Context()
        {
        }

        public KW4_Context(DbContextOptions<KW4_Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessType> AccessType { get; set; }
        public virtual DbSet<AdminContact> AdminContact { get; set; }
        public virtual DbSet<AdminForumMessages> AdminForumMessages { get; set; }
        public virtual DbSet<AgentProxy> AgentProxy { get; set; }
        public virtual DbSet<AisAllHedgetekTickets> AisAllHedgetekTickets { get; set; }
        public virtual DbSet<Alert> Alert { get; set; }
        public virtual DbSet<AlertCategory> AlertCategory { get; set; }
        public virtual DbSet<AlertNotificationStatus> AlertNotificationStatus { get; set; }
        public virtual DbSet<AlertNotificationStatusHistory> AlertNotificationStatusHistory { get; set; }
        public virtual DbSet<AlertStatusType> AlertStatusType { get; set; }
        public virtual DbSet<AlertTemp> AlertTemp { get; set; }
        public virtual DbSet<AllShadoTickets> AllShadoTickets { get; set; }
        public virtual DbSet<ApplicationTrackingCandidate> ApplicationTrackingCandidate { get; set; }
        public virtual DbSet<ApplicationTrackingDocuments> ApplicationTrackingDocuments { get; set; }
        public virtual DbSet<ApplicationTrackingFacility> ApplicationTrackingFacility { get; set; }
        public virtual DbSet<ApplicationTrackingStatus> ApplicationTrackingStatus { get; set; }
        public virtual DbSet<ApplicationTrackingVacancy> ApplicationTrackingVacancy { get; set; }
        public virtual DbSet<ApplicationTrackingVacancyPosting> ApplicationTrackingVacancyPosting { get; set; }
        public virtual DbSet<AreaOfWork> AreaOfWork { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AttachmentSet> AttachmentSet { get; set; }
        public virtual DbSet<Autologin> Autologin { get; set; }
        public virtual DbSet<AwsVpnConnection> AwsVpnConnection { get; set; }
        public virtual DbSet<Bpmheartbeat> Bpmheartbeat { get; set; }
        public virtual DbSet<Bpminstances> Bpminstances { get; set; }
        public virtual DbSet<Bpmitems> Bpmitems { get; set; }
        public virtual DbSet<Bpmitems20190208> Bpmitems20190208 { get; set; }
        public virtual DbSet<Bpmitems20191214> Bpmitems20191214 { get; set; }
        public virtual DbSet<Bpmlog> Bpmlog { get; set; }
        public virtual DbSet<BpmnotificationHistory> BpmnotificationHistory { get; set; }
        public virtual DbSet<BpmnotificationOverrides> BpmnotificationOverrides { get; set; }
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<Branches1> Branches1 { get; set; }
        public virtual DbSet<BrokenAlert> BrokenAlert { get; set; }
        public virtual DbSet<Cabrecords> Cabrecords { get; set; }
        public virtual DbSet<Cabrev> Cabrev { get; set; }
        public virtual DbSet<Capadoc> Capadoc { get; set; }
        public virtual DbSet<Capamain> Capamain { get; set; }
        public virtual DbSet<Caparev> Caparev { get; set; }
        public virtual DbSet<CertificationStatus> CertificationStatus { get; set; }
        public virtual DbSet<CertificationVendor> CertificationVendor { get; set; }
        public virtual DbSet<CheckPoint> CheckPoint { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Client20180302Bad> Client20180302Bad { get; set; }
        public virtual DbSet<ClientAdministrator> ClientAdministrator { get; set; }
        public virtual DbSet<ClientAlertLevels> ClientAlertLevels { get; set; }
        public virtual DbSet<ClientArticles> ClientArticles { get; set; }
        public virtual DbSet<ClientAuditAlertList> ClientAuditAlertList { get; set; }
        public virtual DbSet<ClientAwsaccount> ClientAwsaccount { get; set; }
        public virtual DbSet<ClientAzureWebhook> ClientAzureWebhook { get; set; }
        public virtual DbSet<ClientEscalationProcedureRequest> ClientEscalationProcedureRequest { get; set; }
        public virtual DbSet<ClientHandys> ClientHandys { get; set; }
        public virtual DbSet<ClientHardware> ClientHardware { get; set; }
        public virtual DbSet<ClientHardwareDevice> ClientHardwareDevice { get; set; }
        public virtual DbSet<ClientIp> ClientIp { get; set; }
        public virtual DbSet<ClientLogin> ClientLogin { get; set; }
        public virtual DbSet<ClientLoginToken> ClientLoginToken { get; set; }
        public virtual DbSet<ClientMaintenance> ClientMaintenance { get; set; }
        public virtual DbSet<ClientPassword> ClientPassword { get; set; }
        public virtual DbSet<ClientProcedure> ClientProcedure { get; set; }
        public virtual DbSet<ClientProdSuppAcceptance> ClientProdSuppAcceptance { get; set; }
        public virtual DbSet<ClientProdSuppAcceptanceData> ClientProdSuppAcceptanceData { get; set; }
        public virtual DbSet<ClientProdSuppAcceptanceMeta> ClientProdSuppAcceptanceMeta { get; set; }
        public virtual DbSet<ClientService> ClientService { get; set; }
        public virtual DbSet<ClientSite> ClientSite { get; set; }
        public virtual DbSet<ClientSoftware> ClientSoftware { get; set; }
        public virtual DbSet<ClientSslcertificate> ClientSslcertificate { get; set; }
        public virtual DbSet<ClientTicketNotifications> ClientTicketNotifications { get; set; }
        public virtual DbSet<ClientUsers> ClientUsers { get; set; }
        public virtual DbSet<ClientVendor> ClientVendor { get; set; }
        public virtual DbSet<ClientVendors> ClientVendors { get; set; }
        public virtual DbSet<CmonAccountClients> CmonAccountClients { get; set; }
        public virtual DbSet<CmonPointDevices> CmonPointDevices { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<ContactGroup> ContactGroup { get; set; }
        public virtual DbSet<ContactPerson> ContactPerson { get; set; }
        public virtual DbSet<ContactPersonGroup> ContactPersonGroup { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<Contract2> Contract2 { get; set; }
        public virtual DbSet<Contract2Party> Contract2Party { get; set; }
        public virtual DbSet<ContractDetails> ContractDetails { get; set; }
        public virtual DbSet<ContractDetailsComment> ContractDetailsComment { get; set; }
        public virtual DbSet<ContractDetailsRenewal> ContractDetailsRenewal { get; set; }
        public virtual DbSet<ContractDetailsTermsUpdate> ContractDetailsTermsUpdate { get; set; }
        public virtual DbSet<ContractPartner> ContractPartner { get; set; }
        public virtual DbSet<ContractPartnerMap> ContractPartnerMap { get; set; }
        public virtual DbSet<ContractPartnerSecondaryContact> ContractPartnerSecondaryContact { get; set; }
        public virtual DbSet<ContractPayment> ContractPayment { get; set; }
        public virtual DbSet<ContractPaymentComment> ContractPaymentComment { get; set; }
        public virtual DbSet<ContractReminder> ContractReminder { get; set; }
        public virtual DbSet<ContractTracking> ContractTracking { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CustomEscalationProcedureDevices> CustomEscalationProcedureDevices { get; set; }
        public virtual DbSet<CustomEscalationProcedureNotificationEmailOslist> CustomEscalationProcedureNotificationEmailOslist { get; set; }
        public virtual DbSet<CustomEscalationProcedures> CustomEscalationProcedures { get; set; }
        public virtual DbSet<CustomMonitoring> CustomMonitoring { get; set; }
        public virtual DbSet<CustomMonitoringAlertRules> CustomMonitoringAlertRules { get; set; }
        public virtual DbSet<CustomMonitoringEmailDump> CustomMonitoringEmailDump { get; set; }
        public virtual DbSet<CustomMonitoringFailed> CustomMonitoringFailed { get; set; }
        public virtual DbSet<CustomMonitoringMessageType> CustomMonitoringMessageType { get; set; }
        public virtual DbSet<CustomPerfCounter> CustomPerfCounter { get; set; }
        public virtual DbSet<CustomSqlsensor> CustomSqlsensor { get; set; }
        public virtual DbSet<DailyPlan> DailyPlan { get; set; }
        public virtual DbSet<DailyPlanLock> DailyPlanLock { get; set; }
        public virtual DbSet<DbcounterThreshold> DbcounterThreshold { get; set; }
        public virtual DbSet<DbfragmentedIndexes> DbfragmentedIndexes { get; set; }
        public virtual DbSet<Dbinstance> Dbinstance { get; set; }
        public virtual DbSet<DbinstanceCounter> DbinstanceCounter { get; set; }
        public virtual DbSet<DbinstanceCounterGroup> DbinstanceCounterGroup { get; set; }
        public virtual DbSet<DbinstanceType> DbinstanceType { get; set; }
        public virtual DbSet<DbmissingIndexes> DbmissingIndexes { get; set; }
        public virtual DbSet<Dbproperty> Dbproperty { get; set; }
        public virtual DbSet<DbpropertyHidden> DbpropertyHidden { get; set; }
        public virtual DbSet<DbunusedIndexes> DbunusedIndexes { get; set; }
        public virtual DbSet<Deagent> Deagent { get; set; }
        public virtual DbSet<Debug> Debug { get; set; }
        public virtual DbSet<DeletedAlert> DeletedAlert { get; set; }
        public virtual DbSet<DeletedAlertNotification> DeletedAlertNotification { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<DeliveryItemLocation> DeliveryItemLocation { get; set; }
        public virtual DbSet<DeliveryService> DeliveryService { get; set; }
        public virtual DbSet<DeliveryStatus> DeliveryStatus { get; set; }
        public virtual DbSet<DeliveryTrackingDocuments> DeliveryTrackingDocuments { get; set; }
        public virtual DbSet<Device> Device { get; set; }
        public virtual DbSet<DeviceAgentProxy> DeviceAgentProxy { get; set; }
        public virtual DbSet<DeviceAlarmType> DeviceAlarmType { get; set; }
        public virtual DbSet<DeviceAlertLevelValues> DeviceAlertLevelValues { get; set; }
        public virtual DbSet<DeviceAlertLevels> DeviceAlertLevels { get; set; }
        public virtual DbSet<DeviceAudit> DeviceAudit { get; set; }
        public virtual DbSet<DeviceAuditAlertFollowupHistory> DeviceAuditAlertFollowupHistory { get; set; }
        public virtual DbSet<DeviceAuditAlerts> DeviceAuditAlerts { get; set; }
        public virtual DbSet<DeviceAuditFollowUp> DeviceAuditFollowUp { get; set; }
        public virtual DbSet<DeviceAuditItem> DeviceAuditItem { get; set; }
        public virtual DbSet<DeviceBackup> DeviceBackup { get; set; }
        public virtual DbSet<DeviceBusinessApps> DeviceBusinessApps { get; set; }
        public virtual DbSet<DeviceCactiGraph> DeviceCactiGraph { get; set; }
        public virtual DbSet<DeviceConfig> DeviceConfig { get; set; }
        public virtual DbSet<DeviceConfigHistory> DeviceConfigHistory { get; set; }
        public virtual DbSet<DeviceConfigInfo> DeviceConfigInfo { get; set; }
        public virtual DbSet<DeviceCustomPerfCounter> DeviceCustomPerfCounter { get; set; }
        public virtual DbSet<DeviceCustomSqlsensor> DeviceCustomSqlsensor { get; set; }
        public virtual DbSet<DeviceEscallationProcedure> DeviceEscallationProcedure { get; set; }
        public virtual DbSet<DeviceHardwareStatus> DeviceHardwareStatus { get; set; }
        public virtual DbSet<DeviceHeartbeatAlertLevels> DeviceHeartbeatAlertLevels { get; set; }
        public virtual DbSet<DeviceHost> DeviceHost { get; set; }
        public virtual DbSet<DeviceLabel> DeviceLabel { get; set; }
        public virtual DbSet<DeviceMaintenance> DeviceMaintenance { get; set; }
        public virtual DbSet<DeviceNmsdevice> DeviceNmsdevice { get; set; }
        public virtual DbSet<DeviceSnmpcounter> DeviceSnmpcounter { get; set; }
        public virtual DbSet<DeviceType> DeviceType { get; set; }
        public virtual DbSet<DiskDestructionLog> DiskDestructionLog { get; set; }
        public virtual DbSet<Dnssensor> Dnssensor { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<DocumentCategory> DocumentCategory { get; set; }
        public virtual DbSet<DocumentRecipient> DocumentRecipient { get; set; }
        public virtual DbSet<DocumentVersion> DocumentVersion { get; set; }
        public virtual DbSet<DutyRotation> DutyRotation { get; set; }
        public virtual DbSet<DutyRotationFinalize> DutyRotationFinalize { get; set; }
        public virtual DbSet<DutyRotationNote> DutyRotationNote { get; set; }
        public virtual DbSet<DutyRotationNoteType> DutyRotationNoteType { get; set; }
        public virtual DbSet<DutyShifts> DutyShifts { get; set; }
        public virtual DbSet<DvContacts> DvContacts { get; set; }
        public virtual DbSet<DvCoverage> DvCoverage { get; set; }
        public virtual DbSet<DvEp> DvEp { get; set; }
        public virtual DbSet<DvEp20130814> DvEp20130814 { get; set; }
        public virtual DbSet<DvEpNew> DvEpNew { get; set; }
        public virtual DbSet<EmailDump> EmailDump { get; set; }
        public virtual DbSet<EmailDumpAntiDups> EmailDumpAntiDups { get; set; }
        public virtual DbSet<EmailDumpAttachment> EmailDumpAttachment { get; set; }
        public virtual DbSet<EmailDumpAttachmentBack> EmailDumpAttachmentBack { get; set; }
        public virtual DbSet<EmailRecipients> EmailRecipients { get; set; }
        public virtual DbSet<EmcLuns> EmcLuns { get; set; }
        public virtual DbSet<EmcRaidGroups> EmcRaidGroups { get; set; }
        public virtual DbSet<EmcStorageGroups> EmcStorageGroups { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EngineeringTaskStatus> EngineeringTaskStatus { get; set; }
        public virtual DbSet<Escalation> Escalation { get; set; }
        public virtual DbSet<EscalationContactGroups> EscalationContactGroups { get; set; }
        public virtual DbSet<EscalationContactGroupsHistory> EscalationContactGroupsHistory { get; set; }
        public virtual DbSet<EscalationContacts> EscalationContacts { get; set; }
        public virtual DbSet<EscalationHostGroups> EscalationHostGroups { get; set; }
        public virtual DbSet<EscalationHostGroupsHistory> EscalationHostGroupsHistory { get; set; }
        public virtual DbSet<EscalationProcedureStatisticsHistory> EscalationProcedureStatisticsHistory { get; set; }
        public virtual DbSet<EscalationProcedureStatisticsOverseers> EscalationProcedureStatisticsOverseers { get; set; }
        public virtual DbSet<EscalationProcedureStatisticsProcedureCreators> EscalationProcedureStatisticsProcedureCreators { get; set; }
        public virtual DbSet<EscalationServices> EscalationServices { get; set; }
        public virtual DbSet<EscalationServicesHistory> EscalationServicesHistory { get; set; }
        public virtual DbSet<ExecUpdateDev> ExecUpdateDev { get; set; }
        public virtual DbSet<ExecUpdateNotes> ExecUpdateNotes { get; set; }
        public virtual DbSet<ExecUpdateOps> ExecUpdateOps { get; set; }
        public virtual DbSet<ExecUpdateProjects> ExecUpdateProjects { get; set; }
        public virtual DbSet<ExecUpdateSetDefinitions> ExecUpdateSetDefinitions { get; set; }
        public virtual DbSet<ExecUpdateSubsetDefinitions> ExecUpdateSubsetDefinitions { get; set; }
        public virtual DbSet<Ftpsensor> Ftpsensor { get; set; }
        public virtual DbSet<GlobalSettings> GlobalSettings { get; set; }
        public virtual DbSet<HeartBeat> HeartBeat { get; set; }
        public virtual DbSet<HelpDeskDutyShifts> HelpDeskDutyShifts { get; set; }
        public virtual DbSet<Hrmanager> Hrmanager { get; set; }
        public virtual DbSet<HrmanagerEmployee> HrmanagerEmployee { get; set; }
        public virtual DbSet<Httpsensor> Httpsensor { get; set; }
        public virtual DbSet<Icmpsensor> Icmpsensor { get; set; }
        public virtual DbSet<IcmpsensorHost> IcmpsensorHost { get; set; }
        public virtual DbSet<IcmpsensorOldmonitor> IcmpsensorOldmonitor { get; set; }
        public virtual DbSet<IgnoreDiskVolume> IgnoreDiskVolume { get; set; }
        public virtual DbSet<IncidentMain> IncidentMain { get; set; }
        public virtual DbSet<IncidentRev> IncidentRev { get; set; }
        public virtual DbSet<IncomingTexts> IncomingTexts { get; set; }
        public virtual DbSet<InsidePortSensor> InsidePortSensor { get; set; }
        public virtual DbSet<InsidePortType> InsidePortType { get; set; }
        public virtual DbSet<InternalAudit> InternalAudit { get; set; }
        public virtual DbSet<InternalAuditRecordFiles> InternalAuditRecordFiles { get; set; }
        public virtual DbSet<InternalAuditRecords> InternalAuditRecords { get; set; }
        public virtual DbSet<InternalVendor> InternalVendor { get; set; }
        public virtual DbSet<InvApplication> InvApplication { get; set; }
        public virtual DbSet<InvComponent> InvComponent { get; set; }
        public virtual DbSet<InvComponentDbinstance> InvComponentDbinstance { get; set; }
        public virtual DbSet<InvComponentDevice> InvComponentDevice { get; set; }
        public virtual DbSet<InvDeviceRole> InvDeviceRole { get; set; }
        public virtual DbSet<IsoMonitoringHistoryMain> IsoMonitoringHistoryMain { get; set; }
        public virtual DbSet<IsoMonitoringHistoryMonth> IsoMonitoringHistoryMonth { get; set; }
        public virtual DbSet<IsoMonitoringMain> IsoMonitoringMain { get; set; }
        public virtual DbSet<IsoMonitoringMonth> IsoMonitoringMonth { get; set; }
        public virtual DbSet<Kbarticles> Kbarticles { get; set; }
        public virtual DbSet<KbarticlesToCategories> KbarticlesToCategories { get; set; }
        public virtual DbSet<Kbcategories> Kbcategories { get; set; }
        public virtual DbSet<Kmatapes> Kmatapes { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<Maintenance20180217> Maintenance20180217 { get; set; }
        public virtual DbSet<MaintenanceOccurrencePeriod> MaintenanceOccurrencePeriod { get; set; }
        public virtual DbSet<MedicalHours> MedicalHours { get; set; }
        public virtual DbSet<Meeting> Meeting { get; set; }
        public virtual DbSet<MeetingAction> MeetingAction { get; set; }
        public virtual DbSet<MeetingType> MeetingType { get; set; }
        public virtual DbSet<Miketest> Miketest { get; set; }
        public virtual DbSet<MonitorerHeartBeat> MonitorerHeartBeat { get; set; }
        public virtual DbSet<MonitoringAdjustments> MonitoringAdjustments { get; set; }
        public virtual DbSet<MonitoringHistory> MonitoringHistory { get; set; }
        public virtual DbSet<MySqlsensor> MySqlsensor { get; set; }
        public virtual DbSet<NetworkMaps> NetworkMaps { get; set; }
        public virtual DbSet<NoSha256Devices> NoSha256Devices { get; set; }
        public virtual DbSet<Oraclesensor> Oraclesensor { get; set; }
        public virtual DbSet<Ossec> Ossec { get; set; }
        public virtual DbSet<OutgoingTexts> OutgoingTexts { get; set; }
        public virtual DbSet<PartnersPortal> PartnersPortal { get; set; }
        public virtual DbSet<PasswordAccessLog> PasswordAccessLog { get; set; }
        public virtual DbSet<Passwords> Passwords { get; set; }
        public virtual DbSet<PerformanceAlertLevels> PerformanceAlertLevels { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionClientLogin> PermissionClientLogin { get; set; }
        public virtual DbSet<PostgreSqlsensor> PostgreSqlsensor { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<ProcessToDevice> ProcessToDevice { get; set; }
        public virtual DbSet<ProjectNotes> ProjectNotes { get; set; }
        public virtual DbSet<ProjectPriority> ProjectPriority { get; set; }
        public virtual DbSet<ProjectResourceActual> ProjectResourceActual { get; set; }
        public virtual DbSet<ProjectResourcePlanning> ProjectResourcePlanning { get; set; }
        public virtual DbSet<ProjectStatus> ProjectStatus { get; set; }
        public virtual DbSet<ProjectTracking> ProjectTracking { get; set; }
        public virtual DbSet<ProjectTrackingAction> ProjectTrackingAction { get; set; }
        public virtual DbSet<ProjectTrackingContractDetails> ProjectTrackingContractDetails { get; set; }
        public virtual DbSet<ProjectTrackingDocuments> ProjectTrackingDocuments { get; set; }
        public virtual DbSet<ProjectTrackingFacilities> ProjectTrackingFacilities { get; set; }
        public virtual DbSet<ProjectTrackingOld> ProjectTrackingOld { get; set; }
        public virtual DbSet<ProjectTrackingProject> ProjectTrackingProject { get; set; }
        public virtual DbSet<ProjectTrackingProjectStatementOfCompletionFile> ProjectTrackingProjectStatementOfCompletionFile { get; set; }
        public virtual DbSet<ProjectTrackingSubProject> ProjectTrackingSubProject { get; set; }
        public virtual DbSet<ProjectTrackingTicket> ProjectTrackingTicket { get; set; }
        public virtual DbSet<ProjectTrackingTicketAction> ProjectTrackingTicketAction { get; set; }
        public virtual DbSet<ProjectTrackingTicketSubproject> ProjectTrackingTicketSubproject { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Quotes> Quotes { get; set; }
        public virtual DbSet<RecuringTicket> RecuringTicket { get; set; }
        public virtual DbSet<RecuringTicketInstance> RecuringTicketInstance { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportData> ReportData { get; set; }
        public virtual DbSet<ReportTemplate> ReportTemplate { get; set; }
        public virtual DbSet<ReportTemplateSection> ReportTemplateSection { get; set; }
        public virtual DbSet<ReportTemplateSectionType> ReportTemplateSectionType { get; set; }
        public virtual DbSet<Rumccalls> Rumccalls { get; set; }
        public virtual DbSet<RumccallsStatus> RumccallsStatus { get; set; }
        public virtual DbSet<SaleStatusType> SaleStatusType { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<SalesActions> SalesActions { get; set; }
        public virtual DbSet<SalesActionsInSale> SalesActionsInSale { get; set; }
        public virtual DbSet<SalesCampaign> SalesCampaign { get; set; }
        public virtual DbSet<SalesCampaignActivity> SalesCampaignActivity { get; set; }
        public virtual DbSet<SalesDailyPlan> SalesDailyPlan { get; set; }
        public virtual DbSet<SalesDailyPlanLock> SalesDailyPlanLock { get; set; }
        public virtual DbSet<SalesDailyPlanNotes> SalesDailyPlanNotes { get; set; }
        public virtual DbSet<SalesManagers> SalesManagers { get; set; }
        public virtual DbSet<SalesPartner> SalesPartner { get; set; }
        public virtual DbSet<SalesPartnerLeadContact> SalesPartnerLeadContact { get; set; }
        public virtual DbSet<SalesProducts> SalesProducts { get; set; }
        public virtual DbSet<ScheduledClientReport> ScheduledClientReport { get; set; }
        public virtual DbSet<SearchTmp> SearchTmp { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServicesPeriods> ServicesPeriods { get; set; }
        public virtual DbSet<ShiftCalendar> ShiftCalendar { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<ShipmentPackageType> ShipmentPackageType { get; set; }
        public virtual DbSet<ShipmentServiceType> ShipmentServiceType { get; set; }
        public virtual DbSet<Site> Site { get; set; }
        public virtual DbSet<Smtpsensor> Smtpsensor { get; set; }
        public virtual DbSet<Snmppuller> Snmppuller { get; set; }
        public virtual DbSet<Sqlsensor> Sqlsensor { get; set; }
        public virtual DbSet<Subnet> Subnet { get; set; }
        public virtual DbSet<SumiSupportRotation> SumiSupportRotation { get; set; }
        public virtual DbSet<SumitomoDrives> SumitomoDrives { get; set; }
        public virtual DbSet<SumitomoSwift> SumitomoSwift { get; set; }
        public virtual DbSet<SystemAudit> SystemAudit { get; set; }
        public virtual DbSet<SystemEvent> SystemEvent { get; set; }
        public virtual DbSet<SystemEventToDevice> SystemEventToDevice { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskStatus> TaskStatus { get; set; }
        public virtual DbSet<TaskType> TaskType { get; set; }
        public virtual DbSet<Tcpsensor> Tcpsensor { get; set; }
        public virtual DbSet<TcpsensorHost> TcpsensorHost { get; set; }
        public virtual DbSet<TelehouseAnswers> TelehouseAnswers { get; set; }
        public virtual DbSet<TelehouseClients> TelehouseClients { get; set; }
        public virtual DbSet<TelehouseContacts> TelehouseContacts { get; set; }
        public virtual DbSet<TempXml> TempXml { get; set; }
        public virtual DbSet<Threat> Threat { get; set; }
        public virtual DbSet<ThreatActionPlanType> ThreatActionPlanType { get; set; }
        public virtual DbSet<ThreatAssetType> ThreatAssetType { get; set; }
        public virtual DbSet<ThreatChangeLog> ThreatChangeLog { get; set; }
        public virtual DbSet<ThreatContextType> ThreatContextType { get; set; }
        public virtual DbSet<ThreatControlEffectivenessType> ThreatControlEffectivenessType { get; set; }
        public virtual DbSet<ThreatControlTestResultType> ThreatControlTestResultType { get; set; }
        public virtual DbSet<ThreatResponseType> ThreatResponseType { get; set; }
        public virtual DbSet<ThreatReview> ThreatReview { get; set; }
        public virtual DbSet<ThreatReviewChangeLog> ThreatReviewChangeLog { get; set; }
        public virtual DbSet<ThreatRiskImpactType> ThreatRiskImpactType { get; set; }
        public virtual DbSet<ThreatRiskLikelihoodType> ThreatRiskLikelihoodType { get; set; }
        public virtual DbSet<ThreatRiskRatingType> ThreatRiskRatingType { get; set; }
        public virtual DbSet<ThreatType> ThreatType { get; set; }
        public virtual DbSet<ThreatVulnerabilityType> ThreatVulnerabilityType { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<TicketApprovalStatus> TicketApprovalStatus { get; set; }
        public virtual DbSet<TicketBak> TicketBak { get; set; }
        public virtual DbSet<TicketChangeSet> TicketChangeSet { get; set; }
        public virtual DbSet<TicketClass> TicketClass { get; set; }
        public virtual DbSet<TicketExecutionStatus> TicketExecutionStatus { get; set; }
        public virtual DbSet<TicketField> TicketField { get; set; }
        public virtual DbSet<TicketFollowers> TicketFollowers { get; set; }
        public virtual DbSet<TicketImplementationFlag> TicketImplementationFlag { get; set; }
        public virtual DbSet<TicketPriority> TicketPriority { get; set; }
        public virtual DbSet<TicketReponseSource> TicketReponseSource { get; set; }
        public virtual DbSet<TicketResponse> TicketResponse { get; set; }
        public virtual DbSet<TicketResponseAttachmentTest> TicketResponseAttachmentTest { get; set; }
        public virtual DbSet<TicketSatisfactionStatus> TicketSatisfactionStatus { get; set; }
        public virtual DbSet<TicketStatistics> TicketStatistics { get; set; }
        public virtual DbSet<TicketStatus> TicketStatus { get; set; }
        public virtual DbSet<TicketTlacknowledge> TicketTlacknowledge { get; set; }
        public virtual DbSet<TicketType> TicketType { get; set; }
        public virtual DbSet<TicketUserFollowers> TicketUserFollowers { get; set; }
        public virtual DbSet<TimeOfService> TimeOfService { get; set; }
        public virtual DbSet<TimeTracking> TimeTracking { get; set; }
        public virtual DbSet<TmpUsers> TmpUsers { get; set; }
        public virtual DbSet<TrapMessage> TrapMessage { get; set; }
        public virtual DbSet<TrapMessageVariable> TrapMessageVariable { get; set; }
        public virtual DbSet<TrapOids> TrapOids { get; set; }
        public virtual DbSet<UserCertification> UserCertification { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Usfacilities> Usfacilities { get; set; }
        public virtual DbSet<VClientsExceptRumc> VClientsExceptRumc { get; set; }
        public virtual DbSet<VLastSessionLog> VLastSessionLog { get; set; }
        public virtual DbSet<VReportTiketsTimeTaken> VReportTiketsTimeTaken { get; set; }
        public virtual DbSet<VSatisfactionReport> VSatisfactionReport { get; set; }
        public virtual DbSet<VTicketsExceptRumc> VTicketsExceptRumc { get; set; }
        public virtual DbSet<VTicketsSummaryStatuses> VTicketsSummaryStatuses { get; set; }
        public virtual DbSet<VacationHolidays> VacationHolidays { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorDocuments> VendorDocuments { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<VocationHours> VocationHours { get; set; }
        public virtual DbSet<VocationRequest> VocationRequest { get; set; }
        public virtual DbSet<Vpnmanager> Vpnmanager { get; set; }
        public virtual DbSet<VpnsessionVerificationStatus> VpnsessionVerificationStatus { get; set; }
        public virtual DbSet<Vpnsessions> Vpnsessions { get; set; }
        public virtual DbSet<Vritapes> Vritapes { get; set; }
        public virtual DbSet<VritapesBack> VritapesBack { get; set; }
        public virtual DbSet<VritapesBack20140109> VritapesBack20140109 { get; set; }
        public virtual DbSet<VritapesHistory> VritapesHistory { get; set; }
        public virtual DbSet<VwAspnetApplications> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetProfiles> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetUsers> VwAspnetUsers { get; set; }
        public virtual DbSet<WikiRev> WikiRev { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=KW4_CLEAN;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminContact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phones)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AdminForumMessages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsDisplayed).HasDefaultValueSql("((1))");

                entity.Property(e => e.MessageText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AgentProxy>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastReported).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PassKey)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AisAllHedgetekTickets>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ais_all_hedgetek_tickets");

                entity.Property(e => e.Body)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Alert>(entity =>
            {
                entity.HasIndex(e => e.AlertType);

                entity.HasIndex(e => new { e.AlertStatus, e.Criticality });

                entity.HasIndex(e => new { e.DeviceId, e.AlertType });

                entity.HasIndex(e => new { e.DeviceId, e.AlertType, e.AlertValue });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlertMessage)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.AlertStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.AlertType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.EscalationProcedure)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(((CONVERT([varchar](40),getdate(),(120))+' : Created')+char((13)))+char((10)))");

                entity.Property(e => e.LastUpdateTs)
                    .HasColumnName("LastUpdateTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusSetTs)
                    .HasColumnName("StatusSetTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.SuspendPeriod).HasDefaultValueSql("((24))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AlertCategory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Condition)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlertNotificationStatus>(entity =>
            {
                entity.HasKey(e => e.AlertId)
                    .HasName("PK_AlertStatus");

                entity.Property(e => e.AlertId).ValueGeneratedNever();

                entity.Property(e => e.StatusSetBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AlertNotificationStatusHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StatusSetBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AlertStatusType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LongDesc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDesc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AlertTemp>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlertMessage)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AlertStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.AlertType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.History)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(((CONVERT([varchar](40),getdate(),(120))+' : Created')+char((13)))+char((10)))");

                entity.Property(e => e.LastUpdateTs)
                    .HasColumnName("LastUpdateTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusSetTs)
                    .HasColumnName("StatusSetTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.SuspendPeriod).HasDefaultValueSql("((24))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AllShadoTickets>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("all_shado_tickets");

                entity.Property(e => e.Body)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationTrackingCandidate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdditionInfo).IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Benefits)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BenefitsAccepted)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Issave).HasColumnName("ISSave");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NotesStep1)
                    .HasColumnName("Notes_Step_1")
                    .IsUnicode(false);

                entity.Property(e => e.NotesStep2)
                    .HasColumnName("Notes_Step_2")
                    .IsUnicode(false);

                entity.Property(e => e.NotesStep3)
                    .HasColumnName("Notes_Step_3")
                    .IsUnicode(false);

                entity.Property(e => e.NotesStep4)
                    .HasColumnName("Notes_Step_4")
                    .IsUnicode(false);

                entity.Property(e => e.NotesStep5)
                    .HasColumnName("Notes_Step_5")
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Salary)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryAccepted)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryRequirement)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartDateAccepted).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("((3))");

                entity.Property(e => e.Status1Date)
                    .HasColumnName("Status_1_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status2Date)
                    .HasColumnName("Status_2_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status3Date)
                    .HasColumnName("Status_3_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status4Date)
                    .HasColumnName("Status_4_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status5Date)
                    .HasColumnName("Status_5_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status6Date)
                    .HasColumnName("Status_6_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status7Date)
                    .HasColumnName("Status_7_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status8Date)
                    .HasColumnName("Status_8_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VacancyId).HasColumnName("VacancyID");
            });

            modelBuilder.Entity<ApplicationTrackingDocuments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandidateId).HasColumnName("CandidateID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MapFile)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ApplicationTrackingFacility>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VacancyId).HasColumnName("VacancyID");
            });

            modelBuilder.Entity<ApplicationTrackingStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignedColor)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationTrackingVacancy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ApplicationTrackingVacancyPosting>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatePosted).HasColumnType("datetime");

                entity.Property(e => e.Duration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expiration).HasColumnType("datetime");

                entity.Property(e => e.Fee)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VacancyId).HasColumnName("VacancyID");

                entity.Property(e => e.WebAddress)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('http://')");
            });

            modelBuilder.Entity<AreaOfWork>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Articles>(entity =>
            {
                entity.HasKey(e => new { e.FilePath, e.Id });

                entity.Property(e => e.FilePath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ApprovedBy).HasDefaultValueSql("((2))");

                entity.Property(e => e.BriefDescription).IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateCached).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.FileContent)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ReviewedBy).HasDefaultValueSql("((2))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Version)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.VisibleTo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.AreaOfWork)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.AreaOfWorkId)
                    .HasConstraintName("FK_Articles_AreaOfWork");
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C9862B55AD6")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__30910331C4D41B6E")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .IsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C0183ACC5");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__50E6C0E9");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC1F0FF4E8B");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4DCA04B434")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__40B05920");
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthorizedRoles)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.File)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SetId).HasColumnName("SetID");

                entity.HasOne(d => d.Set)
                    .WithMany(p => p.Attachment)
                    .HasForeignKey(d => d.SetId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Attachment_AttachmentSet");
            });

            modelBuilder.Entity<AttachmentSet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.OwnerId)
                    .HasColumnName("OwnerID")
                    .HasComment("For information only");
            });

            modelBuilder.Entity<Autologin>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("UQ__Autologin__691284DE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasColumnType("decimal(32, 0)");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AwsVpnConnection>(entity =>
            {
                entity.ToTable("AWS_VPN_Connection");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Environment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastCheckedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusChangedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bpmheartbeat>(entity =>
            {
                entity.ToTable("BPMHeartbeat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((37))");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.EscalationProcedure)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastReportedIp)
                    .HasColumnName("LastReportedIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastReportedPayload)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.LastReportedTs)
                    .HasColumnName("LastReportedTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bpminstances>(entity =>
            {
                entity.ToTable("BPMInstances");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bpmitems>(entity =>
            {
                entity.ToTable("BPMItems");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bpmitems20190208>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BPMItems_20190208");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bpmitems20191214>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BPMItems_20191214");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bpmlog>(entity =>
            {
                entity.ToTable("BPMLog");

                entity.HasIndex(e => new { e.Status, e.Ts });

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BpmnotificationHistory>(entity =>
            {
                entity.ToTable("BPMNotificationHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Note)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BpmnotificationOverrides>(entity =>
            {
                entity.ToTable("BPMNotificationOverrides");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InstanceId).HasColumnName("InstanceID");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationDate).HasColumnType("date");
            });

            modelBuilder.Entity<Branches>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("__Branches");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Branches1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("__Branches1");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BrokenAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("broken_alert");

                entity.Property(e => e.AlertMessage)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AlertType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.History)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdateTs)
                    .HasColumnName("LastUpdateTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusSetTs)
                    .HasColumnName("StatusSetTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Cabrecords>(entity =>
            {
                entity.ToTable("CABRecords");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.Participant).IsUnicode(false);

                entity.HasOne(d => d.UserCreatedNavigation)
                    .WithMany(p => p.Cabrecords)
                    .HasForeignKey(d => d.UserCreated)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CABRecords_UserCreated");
            });

            modelBuilder.Entity<Cabrev>(entity =>
            {
                entity.ToTable("CABRev");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RevId).HasColumnName("RevID");

                entity.Property(e => e.StatusUpdateMessage).IsUnicode(false);
            });

            modelBuilder.Entity<Capadoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAPADoc");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RevId).HasColumnName("RevID");

                entity.Property(e => e.SupportingDoc).IsRequired();

                entity.Property(e => e.SupportingDocName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Capamain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAPAMain");

                entity.Property(e => e.ActualDeadline).HasColumnType("date");

                entity.Property(e => e.ActualDeadlineEmailSent)
                    .HasColumnName("ActualDeadline_EmailSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.CaorPa).HasColumnName("CAorPA");

                entity.Property(e => e.Cpa)
                    .HasColumnName("CPA")
                    .IsUnicode(false);

                entity.Property(e => e.Cpat)
                    .HasColumnName("CPAT")
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Observation).IsUnicode(false);

                entity.Property(e => e.SetDeadline).HasColumnType("date");

                entity.Property(e => e.SetDeadlineEmailSent)
                    .HasColumnName("SetDeadline_EmailSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.VerificationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Caparev>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAPARev");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RevId).HasColumnName("RevID");

                entity.Property(e => e.StatusUpdateMessage).IsUnicode(false);
            });

            modelBuilder.Entity<CertificationStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CertificationVendor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CheckPoint>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Broken).HasColumnName("broken");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CrawlerId).HasColumnName("CrawlerID");

                entity.Property(e => e.CreatingTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Monitoring)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.Review).HasColumnType("datetime");

                entity.Property(e => e.Service)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlertNotificationsRecipients)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BackupRecoveryInfo).HasColumnType("text");

                entity.Property(e => e.ClientKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CmonEscalationProcedure)
                    .HasColumnName("CMonEscalationProcedure")
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceAuditCity).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditClientName).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditEmail).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditFax).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditPhone).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditState).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditStreet).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditWebsite).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditZip)
                    .HasColumnName("DeviceAuditZIP")
                    .HasMaxLength(500);

                entity.Property(e => e.EscalationProcedure).IsUnicode(false);

                entity.Property(e => e.EscalationProcedureUpdated)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EscallationProcedure).IsUnicode(false);

                entity.Property(e => e.Itservices)
                    .HasColumnName("ITServices")
                    .HasColumnType("text");

                entity.Property(e => e.MaintModeStart).HasColumnType("datetime");

                entity.Property(e => e.PasswordInfo).HasColumnType("text");

                entity.Property(e => e.PortalMenuMask).HasDefaultValueSql("(0xFFFFFFFF)");

                entity.Property(e => e.RelationshipManagerId).HasColumnName("RelationshipManagerID");

                entity.Property(e => e.ReportPrefix)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeOfService).HasColumnType("text");

                entity.Property(e => e.Sla).HasColumnName("SLA");

                entity.Property(e => e.SoftwareInfo).HasColumnType("text");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Client20180302Bad>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Client_20180302_bad");

                entity.Property(e => e.AlertNotificationsRecipients)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BackupRecoveryInfo).HasColumnType("text");

                entity.Property(e => e.ClientKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CmonEscalationProcedure)
                    .HasColumnName("CMonEscalationProcedure")
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceAuditCity).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditClientName).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditEmail).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditFax).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditPhone).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditState).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditStreet).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditWebsite).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditZip)
                    .HasColumnName("DeviceAuditZIP")
                    .HasMaxLength(500);

                entity.Property(e => e.EscalationProcedure).IsUnicode(false);

                entity.Property(e => e.EscalationProcedureUpdated)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EscallationProcedure).IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Itservices)
                    .HasColumnName("ITServices")
                    .HasColumnType("text");

                entity.Property(e => e.MaintModeStart).HasColumnType("datetime");

                entity.Property(e => e.PasswordInfo).HasColumnType("text");

                entity.Property(e => e.RelationshipManagerId).HasColumnName("RelationshipManagerID");

                entity.Property(e => e.ReportPrefix)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeOfService).HasColumnType("text");

                entity.Property(e => e.Sla).HasColumnName("SLA");

                entity.Property(e => e.SoftwareInfo).HasColumnType("text");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ClientAdministrator>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.ClientAdministrator)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientAdministrator");
            });

            modelBuilder.Entity<ClientAlertLevels>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientArticles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ClientArticleId)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientAuditAlertList>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientEmployeeEmail)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ClientEmployeeName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ClientAwsaccount>(entity =>
            {
                entity.ToTable("ClientAWSAccount");

                entity.Property(e => e.AwsaccountId)
                    .IsRequired()
                    .HasColumnName("AWSAccountId")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientAzureWebhook>(entity =>
            {
                entity.Property(e => e.WebKey)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientEscalationProcedureRequest>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.Status })
                    .HasName("IX_ClientEscalationProcedureRequest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientLoginId).HasColumnName("ClientLoginID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.EscalationProcedure).IsUnicode(false);

                entity.Property(e => e.UserIdupdated).HasColumnName("UserIDUpdated");
            });

            modelBuilder.Entity<ClientHandys>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Imei)
                    .IsRequired()
                    .HasColumnName("IMEI")
                    .HasMaxLength(50);

                entity.Property(e => e.OsVersion).HasMaxLength(50);

                entity.Property(e => e.Token).HasMaxLength(200);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ClientHardware>(entity =>
            {
                entity.Property(e => e.EndOfWarrantyDate).HasColumnType("date");

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.ClientHardware)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientHardware_Client");

                entity.HasOne(d => d.ClientVendorNavigation)
                    .WithMany(p => p.ClientHardware)
                    .HasForeignKey(d => d.ClientVendor)
                    .HasConstraintName("FK_ClientHardware_ClientVendors");
            });

            modelBuilder.Entity<ClientHardwareDevice>(entity =>
            {
                entity.Property(e => e.EndOfLifeDate).HasColumnType("date");

                entity.HasOne(d => d.ClientHardwareNavigation)
                    .WithMany(p => p.ClientHardwareDevice)
                    .HasForeignKey(d => d.ClientHardware)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientHardwareDevice_ClientHardware");

                entity.HasOne(d => d.DeviceNavigation)
                    .WithMany(p => p.ClientHardwareDevice)
                    .HasForeignKey(d => d.Device)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientHardwareDevice_Device");
            });

            modelBuilder.Entity<ClientIp>(entity =>
            {
                entity.HasKey(e => e.IpAddress)
                    .HasName("PK_ClientIp_1");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_ClientIp_DeviceID");

                entity.Property(e => e.IpAddress).ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceRole)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SubnetId).HasColumnName("SubnetID");

                entity.Property(e => e.TranslationIp).HasColumnName("TranslationIP");
            });

            modelBuilder.Entity<ClientLogin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("PWD")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientLogin)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientLogin_Client");
            });

            modelBuilder.Entity<ClientLoginToken>(entity =>
            {
                entity.HasIndex(e => e.ClientLoginId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientLoginId).HasColumnName("ClientLoginID");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ClientMaintenance>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OccurrencePeriodId).HasColumnName("OccurrencePeriodID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ClientPassword>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Access)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AccessTypeId).HasColumnName("AccessTypeID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("PWD")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientProcedure>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.Property(e => e.ClientId).ValueGeneratedNever();

                entity.Property(e => e.TicketProcedure)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientProdSuppAcceptance>(entity =>
            {
                entity.HasKey(e => e.ClientId);

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptedOn)
                    .HasColumnName("accepted_on")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SignoffProdManagerUserId).HasColumnName("signoff_prod_manager_user_id");

                entity.Property(e => e.UpdatedUserId).HasColumnName("updated_user_id");
            });

            modelBuilder.Entity<ClientProdSuppAcceptanceData>(entity =>
            {
                entity.HasIndex(e => new { e.ClientId, e.MetaId })
                    .HasName("IX_ClientProdSuppAcceptanceData")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateUpdated)
                    .HasColumnName("date_updated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InEms)
                    .HasColumnName("in_ems")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MetaId).HasColumnName("meta_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<ClientProdSuppAcceptanceMeta>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Additional)
                    .HasColumnName("additional")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");

                entity.Property(e => e.ProvidedBy)
                    .HasColumnName("provided_by")
                    .HasMaxLength(100);

                entity.Property(e => e.SupportInformation)
                    .IsRequired()
                    .HasColumnName("support_information")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ClientService>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_ClientService_1");

                entity.HasIndex(e => new { e.ClientId, e.ServiceId })
                    .HasName("IX_ClientService")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ClientSite>(entity =>
            {
                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientSite)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientSite_Client");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ClientSite)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientSite_Site");
            });

            modelBuilder.Entity<ClientSoftware>(entity =>
            {
                entity.Property(e => e.EndOfLifeDate).HasColumnType("date");

                entity.Property(e => e.SupportDate).HasColumnType("date");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.ClientSoftware)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientSoftwareClient");
            });

            modelBuilder.Entity<ClientSslcertificate>(entity =>
            {
                entity.ToTable("ClientSSLCertificate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CertificateExpiresOn)
                    .HasColumnName("Certificate_ExpiresOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.CertificateIssuer)
                    .HasColumnName("Certificate_Issuer")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateLastChecked)
                    .HasColumnName("Certificate_LastChecked")
                    .HasColumnType("datetime");

                entity.Property(e => e.CertificateName)
                    .HasColumnName("Certificate_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateSerial)
                    .HasColumnName("Certificate_Serial")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientTicketNotifications>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");
            });

            modelBuilder.Entity<ClientUsers>(entity =>
            {
                entity.Property(e => e.CellPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientVendor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttachmentSetId).HasColumnName("AttachmentSetID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EscallationProcedure)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInfo)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.SalesName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPhone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Services)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UserNotes)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.HasOne(d => d.AttachmentSet)
                    .WithMany(p => p.ClientVendor)
                    .HasForeignKey(d => d.AttachmentSetId)
                    .HasConstraintName("FK_ClientVendors_AttachmentSet");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientVendor)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientVendors_Client");
            });

            modelBuilder.Entity<ClientVendors>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MapFile).HasColumnType("image");

                entity.Property(e => e.OtherInformation).HasColumnType("text");

                entity.Property(e => e.SalesAssociateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesProvided).HasColumnType("text");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserNotes).HasColumnType("text");

                entity.Property(e => e.VendorEscalationProcedure).HasColumnType("text");

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmonAccountClients>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__CMonAccountClien__6BEEF189");

                entity.ToTable("CMonAccountClients");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasColumnName("ClientID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EscalationProcedure)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CmonPointDevices>(entity =>
            {
                entity.HasKey(e => e.PointId)
                    .HasName("PK_CMonDevicePoints");

                entity.ToTable("CMonPointDevices");

                entity.Property(e => e.PointId)
                    .HasColumnName("PointID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.EscalationProcedure)
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MainSwitchboardphone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.St)
                    .HasColumnName("ST")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subscribed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UnsubscribeDate).HasColumnType("datetime");

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContactGroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ContactPerson>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .HasName("ix_ContactPerson_UniqueEmail")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ContactPersonGroup>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.GroupNavigation)
                    .WithMany(p => p.ContactPersonGroup)
                    .HasForeignKey(d => d.Group)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactGroup");

                entity.HasOne(d => d.PersonNavigation)
                    .WithMany(p => p.ContactPersonGroup)
                    .HasForeignKey(d => d.Person)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactPerson");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractClient");

                entity.HasOne(d => d.DeRepNavigation)
                    .WithMany(p => p.Contract)
                    .HasForeignKey(d => d.DeRep)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractRep");
            });

            modelBuilder.Entity<Contract2>(entity =>
            {
                entity.Property(e => e.ExpirationDate).HasColumnType("date");

                entity.Property(e => e.Po).HasColumnName("PO");

                entity.Property(e => e.SignDate).HasColumnType("date");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.Contract2ClientNavigation)
                    .HasForeignKey(d => d.Client)
                    .HasConstraintName("FK_Contract2Client");

                entity.HasOne(d => d.PartnerNavigation)
                    .WithMany(p => p.Contract2PartnerNavigation)
                    .HasForeignKey(d => d.Partner)
                    .HasConstraintName("FK_Contract2Partner");

                entity.HasOne(d => d.VendorNavigation)
                    .WithMany(p => p.Contract2VendorNavigation)
                    .HasForeignKey(d => d.Vendor)
                    .HasConstraintName("FK_Contract2Vendor");
            });

            modelBuilder.Entity<Contract2Party>(entity =>
            {
                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.Contract2Party)
                    .HasForeignKey(d => d.Client)
                    .HasConstraintName("FK_Contart2PartyClient");
            });

            modelBuilder.Entity<ContractDetails>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CommitmentDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContractNavigation)
                    .WithMany(p => p.ContractDetails)
                    .HasForeignKey(d => d.Contract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractDetails");

                entity.HasOne(d => d.ProjectManagerNavigation)
                    .WithMany(p => p.ContractDetails)
                    .HasForeignKey(d => d.ProjectManager)
                    .HasConstraintName("FK_ContractProjectManager");

                entity.HasOne(d => d.VendorNavigation)
                    .WithMany(p => p.ContractDetails)
                    .HasForeignKey(d => d.Vendor)
                    .HasConstraintName("FK_ContractVendor");
            });

            modelBuilder.Entity<ContractDetailsComment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DetailsNavigation)
                    .WithMany(p => p.ContractDetailsComment)
                    .HasForeignKey(d => d.Details)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractDetailsCommentDetails");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.ContractDetailsComment)
                    .HasForeignKey(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractDetailsCommentUser");
            });

            modelBuilder.Entity<ContractDetailsRenewal>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.RenewalDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DetailsNavigation)
                    .WithMany(p => p.ContractDetailsRenewal)
                    .HasForeignKey(d => d.Details)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractDetailsRenewalDetails");
            });

            modelBuilder.Entity<ContractDetailsTermsUpdate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Update).IsRequired();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DetailsNavigation)
                    .WithMany(p => p.ContractDetailsTermsUpdate)
                    .HasForeignKey(d => d.Details)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractDetailsTermsUpdateDetails");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.ContractDetailsTermsUpdate)
                    .HasForeignKey(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractDetailsTermsUpdateUser");
            });

            modelBuilder.Entity<ContractPartner>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ContractPartnerMap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContractNavigation)
                    .WithMany(p => p.ContractPartnerMap)
                    .HasForeignKey(d => d.Contract)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractPartnerMapContract");

                entity.HasOne(d => d.PartnerNavigation)
                    .WithMany(p => p.ContractPartnerMap)
                    .HasForeignKey(d => d.Partner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractPartnerMapPartner");
            });

            modelBuilder.Entity<ContractPartnerSecondaryContact>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContractPartnerNavigation)
                    .WithMany(p => p.ContractPartnerSecondaryContact)
                    .HasForeignKey(d => d.ContractPartner)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractPartnerSecondaryContact");
            });

            modelBuilder.Entity<ContractPayment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LastNotified).HasColumnType("datetime");

                entity.Property(e => e.Number).IsRequired();

                entity.Property(e => e.Po).HasColumnName("PO");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ContractDetailsNavigation)
                    .WithMany(p => p.ContractPayment)
                    .HasForeignKey(d => d.ContractDetails)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractDetailsPayment");
            });

            modelBuilder.Entity<ContractPaymentComment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.PaymentNavigation)
                    .WithMany(p => p.ContractPaymentComment)
                    .HasForeignKey(d => d.Payment)
                    .HasConstraintName("FK_PaymentComment");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.ContractPaymentComment)
                    .HasForeignKey(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractPaymentCommentUser");
            });

            modelBuilder.Entity<ContractReminder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DetailsNavigation)
                    .WithMany(p => p.ContractReminder)
                    .HasForeignKey(d => d.Details)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractReminder");
            });

            modelBuilder.Entity<ContractTracking>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Number).IsRequired();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DetailsNavigation)
                    .WithMany(p => p.ContractTracking)
                    .HasForeignKey(d => d.Details)
                    .HasConstraintName("FK_ContractTrackingContractDetails");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Country1)
                    .IsRequired()
                    .HasColumnName("Country")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomEscalationProcedureDevices>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.DeviceNavigation)
                    .WithMany(p => p.CustomEscalationProcedureDevices)
                    .HasForeignKey(d => d.Device)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomEscalationProcedures_Device");

                entity.HasOne(d => d.EscProcRefNavigation)
                    .WithMany(p => p.CustomEscalationProcedureDevices)
                    .HasForeignKey(d => d.EscProcRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomEscalationProcedures_EscProcRef");
            });

            modelBuilder.Entity<CustomEscalationProcedureNotificationEmailOslist>(entity =>
            {
                entity.ToTable("CustomEscalationProcedureNotificationEmailOSList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Os).HasColumnName("OS");

                entity.HasOne(d => d.EscProcRefNavigation)
                    .WithMany(p => p.CustomEscalationProcedureNotificationEmailOslist)
                    .HasForeignKey(d => d.EscProcRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomEscalationProcedureNotificationEmailOSList_EscProcRef");

                entity.HasOne(d => d.OsNavigation)
                    .WithMany(p => p.CustomEscalationProcedureNotificationEmailOslist)
                    .HasForeignKey(d => d.Os)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomEscalationProcedureNotificationEmailOSList_OS");
            });

            modelBuilder.Entity<CustomEscalationProcedures>(entity =>
            {
                entity.HasIndex(e => new { e.MessagePattern, e.EscalationProcedure, e.ClientId })
                    .HasName("IX_CustomEscalationProcedures_ClientId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllDevicesSelected)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.CustomDevicePattern)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EscalationProcedure)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MessagePattern)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OverseerAfkemailLastSent)
                    .HasColumnName("OverseerAFKEmail_LastSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.OverseerExtendTimeEmailSent)
                    .HasColumnName("OverseerExtendTime_EmailSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcedureCreatedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcedureIdtag).HasColumnName("Procedure_IDTag");

                entity.Property(e => e.ProcedureReviewedOn).HasColumnType("datetime");

                entity.Property(e => e.RecurTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.RecurTimeTo).HasColumnType("datetime");

                entity.Property(e => e.SendEmailNotificationsAllOs)
                    .IsRequired()
                    .HasColumnName("SendEmailNotifications_AllOS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProcedureCreatorNavigation)
                    .WithMany(p => p.CustomEscalationProceduresProcedureCreatorNavigation)
                    .HasForeignKey(d => d.ProcedureCreator)
                    .HasConstraintName("FK_CustomEscalationProcedures_ProcedureCreator");

                entity.HasOne(d => d.ProcedureReviewerNavigation)
                    .WithMany(p => p.CustomEscalationProceduresProcedureReviewerNavigation)
                    .HasForeignKey(d => d.ProcedureReviewer)
                    .HasConstraintName("FK_CustomEscalationProcedures_ProcedureReviewer");
            });

            modelBuilder.Entity<CustomMonitoring>(entity =>
            {
                entity.HasIndex(e => e.EmailFrom)
                    .HasName("CustomMonitoringEmailFromIndx");

                entity.HasIndex(e => e.Ts);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.Body)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomMonitoringAlertRules>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.DoesNotContain)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmailBody)
                    .HasColumnName("EMailBody")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFrom)
                    .IsRequired()
                    .HasColumnName("EMailFrom")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasColumnName("EMailSubject")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTypeId).HasColumnName("MessageTypeID");

                entity.Property(e => e.ScheduleEndTime).HasColumnType("datetime");

                entity.Property(e => e.ScheduleStartTime).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("TS")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomMonitoringEmailDump>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bcc)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Body).HasColumnType("text");

                entity.Property(e => e.BodyFormat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDate).HasColumnType("datetime");

                entity.Property(e => e.From)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyTo)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TextBody)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomMonitoringFailed>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cmcounter).HasColumnName("CMCounter");

                entity.Property(e => e.Cmmessage)
                    .HasColumnName("CMMessage")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomMonitoringMessageType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomPerfCounter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Counter)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CounterType)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Instance)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Object)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomSqlsensor>(entity =>
            {
                entity.ToTable("CustomSQLSensor");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DailyPlan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateFinished)
                    .HasColumnName("date_finished")
                    .HasColumnType("date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProjectActionId).HasColumnName("project_action_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SubprojectId).HasColumnName("subproject_id");
            });

            modelBuilder.Entity<DailyPlanLock>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<DbcounterThreshold>(entity =>
            {
                entity.ToTable("DBCounterThreshold");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Expression)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.GenerateAlerts).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Parameter1)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Parameter2).IsUnicode(false);

                entity.Property(e => e.Parameter3).IsUnicode(false);

                entity.Property(e => e.Root).IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('H')");
            });

            modelBuilder.Entity<DbfragmentedIndexes>(entity =>
            {
                entity.ToTable("DBFragmentedIndexes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndexName)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Instance)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Dbinstance>(entity =>
            {
                entity.ToTable("DBInstance");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.InstanceName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.Dbinstance)
                    .HasForeignKey(d => d.DeviceId)
                    .HasConstraintName("FK_DBInstance_Device");

                entity.HasOne(d => d.InstanceType)
                    .WithMany(p => p.Dbinstance)
                    .HasForeignKey(d => d.InstanceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DBInstance_DBInstanceType");
            });

            modelBuilder.Entity<DbinstanceCounter>(entity =>
            {
                entity.ToTable("DBInstanceCounter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DbinstanceCounterGroupId).HasColumnName("DBInstanceCounterGroupID");

                entity.Property(e => e.DbinstanceTypeId).HasColumnName("DBInstanceTypeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbinstanceCounterGroup>(entity =>
            {
                entity.ToTable("DBInstanceCounterGroup");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DbinstanceTypeId).HasColumnName("DBInstanceTypeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbinstanceType>(entity =>
            {
                entity.ToTable("DBInstanceType");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbmissingIndexes>(entity =>
            {
                entity.ToTable("DBMissingIndexes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Columns).IsUnicode(false);

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Include).IsUnicode(false);

                entity.Property(e => e.IndexName)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.Instance)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Dbproperty>(entity =>
            {
                entity.HasKey(e => e.Parameter);

                entity.ToTable("DBProperty");

                entity.HasIndex(e => e.InstanceName)
                    .HasName("IX_DBPropertyInstance");

                entity.HasIndex(e => e.ParamShort)
                    .HasName("IX_DBPropertyParam");

                entity.HasIndex(e => new { e.DeviceId, e.Parameter });

                entity.HasIndex(e => new { e.Value, e.Ts });

                entity.Property(e => e.Parameter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InstanceName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(coalesce(left([parameter],nullif(charindex('/',[parameter]),(0))-(1)),[parameter]))");

                entity.Property(e => e.ParamShort)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(coalesce(right([parameter],nullif(charindex(reverse('/'),reverse([parameter])),(0))-(1)),[parameter]))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DbpropertyHidden>(entity =>
            {
                entity.HasKey(e => e.Parameter);

                entity.ToTable("DBPropertyHidden");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DbunusedIndexes>(entity =>
            {
                entity.ToTable("DBUnusedIndexes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Columns).IsUnicode(false);

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Include).IsUnicode(false);

                entity.Property(e => e.IndexName).IsUnicode(false);

                entity.Property(e => e.Instance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Deagent>(entity =>
            {
                entity.ToTable("DEAgent");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Debug>(entity =>
            {
                entity.ToTable("debug");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeletedAlert>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__DeletedAlert__13C7D8B9")
                    .IsClustered(false);

                entity.HasIndex(e => e.DeviceId);

                entity.HasIndex(e => e.StatusSetTs)
                    .HasName("IX_DeletedAlert_LastUpdate")
                    .IsClustered();

                entity.HasIndex(e => new { e.Id, e.DeviceId, e.StatusSetTs, e.AlertCounter, e.Ts })
                    .HasName("IX_DeletedAlert_AlertCounter_ts");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlertMessage)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.AlertStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.AlertType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.EscalationProcedure)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateTs)
                    .HasColumnName("LastUpdateTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.NotifyWhenCleared).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusSetTs)
                    .HasColumnName("StatusSetTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.SuspendPeriod).HasDefaultValueSql("((24))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DeletedAlertNotification>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__DeletedAlertNotification")
                    .IsClustered(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlertMessage)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.AlertStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.AlertType)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.EscalationProcedure)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateTs)
                    .HasColumnName("LastUpdateTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.NotifyWhenCleared).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusSetTs)
                    .HasColumnName("StatusSetTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.SuspendPeriod).HasDefaultValueSql("((24))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressedToCompanyId).HasColumnName("AddressedToCompanyID");

                entity.Property(e => e.AddressedToId).HasColumnName("AddressedToID");

                entity.Property(e => e.AmountOfPackages)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AssignedPerson)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.CreatorId).HasColumnName("CreatorID");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryServiceId).HasColumnName("DeliveryServiceID");

                entity.Property(e => e.DeliveryStatusId).HasColumnName("DeliveryStatusID");

                entity.Property(e => e.ExistingCompany).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExistingSender).HasDefaultValueSql("((1))");

                entity.Property(e => e.ItemLocationId).HasColumnName("ItemLocationID");

                entity.Property(e => e.NumberOfPackages)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PackingSlipNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PotentialName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.RelatedProjectId).HasColumnName("RelatedProjectID");

                entity.Property(e => e.RelatedProjectIdAddressedTo).HasColumnName("RelatedProjectID_AddressedTo");

                entity.Property(e => e.RelatedProjectIdSender).HasColumnName("RelatedProjectID_Sender");

                entity.Property(e => e.SenderCompanyId).HasColumnName("SenderCompanyID");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.TicketIdAddressedTo).HasColumnName("TicketID_AddressedTo");

                entity.Property(e => e.TicketIdSender).HasColumnName("TicketID_Sender");

                entity.Property(e => e.Tracking)
                    .IsRequired()
                    .HasColumnName("Tracking#")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeliveryItemLocation>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryService>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryTrackingDocuments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeliveryId).HasColumnName("DeliveryID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MapFile)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.ReportDbvolumes })
                    .HasName("IX_Device_ReportDBVolumes");

                entity.HasIndex(e => new { e.Id, e.ReportIcmp })
                    .HasName("IX_Device_ReportICMP");

                entity.HasIndex(e => new { e.Id, e.ReportProcesses })
                    .HasName("IX_Device_ReportProcesses");

                entity.HasIndex(e => new { e.Id, e.DeviceName, e.ClientId })
                    .HasName("IX_Device_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackupProcedure)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.BashVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessAdditionalInfo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessAppsRunning)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ConnectedPort)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectedToId).HasColumnName("ConnectedToID");

                entity.Property(e => e.ConnectionsMapOrigFilename)
                    .HasColumnName("ConnectionsMap_OrigFilename")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionsMapSavedFilename)
                    .HasColumnName("ConnectionsMap_SavedFilename")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeagentVersion)
                    .HasColumnName("DEAgentVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceMakeId).HasColumnName("DeviceMakeID");

                entity.Property(e => e.DeviceMakeOther)
                    .HasColumnName("DeviceMake_Other")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceRole)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dnsservers)
                    .HasColumnName("DNSServers")
                    .IsUnicode(false);

                entity.Property(e => e.EscallationProcedure)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.HardwareSpecs)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HardwareSpecsOrigFilename)
                    .HasColumnName("HardwareSpecs_OrigFilename")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HardwareSpecsSavedFilename)
                    .HasColumnName("HardwareSpecs_SavedFilename")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Host)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IndicatorHd).HasColumnName("Indicator_HD");

                entity.Property(e => e.IndicatorNa).HasColumnName("Indicator_NA");

                entity.Property(e => e.IndicatorPs).HasColumnName("Indicator_PS");

                entity.Property(e => e.InstallDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddresses)
                    .HasColumnName("IPAddresses")
                    .IsUnicode(false);

                entity.Property(e => e.KernelVersion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastPatchDate).HasColumnType("datetime");

                entity.Property(e => e.Ledlocation)
                    .IsRequired()
                    .HasColumnName("LEDLocation")
                    .HasMaxLength(2)
                    .HasDefaultValueSql("('FB')");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerStatsHard)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerStatsSoft)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Memory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MonitoringConsiderationId).HasColumnName("MonitoringConsiderationID");

                entity.Property(e => e.MonitoringCoverage)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NewDeagentVersion)
                    .HasColumnName("NewDEAgentVersion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingSystemId).HasColumnName("OperatingSystemID");

                entity.Property(e => e.OperatingSystemOther)
                    .HasColumnName("OperatingSystem_Other")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProcpsVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.ReportCustomPerfCounter).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportCustomSql).HasColumnName("ReportCustomSQL");

                entity.Property(e => e.ReportDbvolumes).HasColumnName("ReportDBVolumes");

                entity.Property(e => e.ReportDns).HasColumnName("ReportDNS");

                entity.Property(e => e.ReportFileWatcher).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportFtp).HasColumnName("ReportFTP");

                entity.Property(e => e.ReportHttp).HasColumnName("ReportHTTP");

                entity.Property(e => e.ReportIcmp).HasColumnName("ReportICMP");

                entity.Property(e => e.ReportMySql).HasColumnName("ReportMySQL");

                entity.Property(e => e.ReportNics)
                    .HasColumnName("ReportNICs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportPostgreSql).HasColumnName("ReportPostgreSQL");

                entity.Property(e => e.ReportSmtp).HasColumnName("ReportSMTP");

                entity.Property(e => e.ReportSql).HasColumnName("ReportSQL");

                entity.Property(e => e.ReportSqlfiles).HasColumnName("ReportSQLFiles");

                entity.Property(e => e.ReportTcp).HasColumnName("ReportTCP");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SupportGroup)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOfServiceId).HasColumnName("TimeOfServiceID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uptime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Uuid).HasColumnName("UUID");

                entity.Property(e => e.WarrantyExpire).HasColumnType("datetime");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.Device)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_Device_Site");
            });

            modelBuilder.Entity<DeviceAgentProxy>(entity =>
            {
                entity.Property(e => e.Credentials)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((0))");

                entity.Property(e => e.HostName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastError)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastReported).HasColumnType("datetime");

                entity.Property(e => e.LastStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AgentProxy)
                    .WithMany(p => p.DeviceAgentProxy)
                    .HasForeignKey(d => d.AgentProxyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceAgentProxy_AgentProxy");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DeviceAgentProxy)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceAgentProxy_Device");
            });

            modelBuilder.Entity<DeviceAlarmType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<DeviceAlertLevelValues>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ValueName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceAlertLevels>(entity =>
            {
                entity.HasIndex(e => new { e.ValueName, e.DeviceId })
                    .HasName("IDX_DeviceAlertLevels_DeviceID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ValueName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceAudit>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("IX_DeviceAudit_1");

                entity.HasIndex(e => e.CreatedDate)
                    .HasName("IX_DeviceAudit");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsHidden).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DeviceAudit)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceAudit_Client");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.DeviceAuditCreatedUser)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceAudit_Users");

                entity.HasOne(d => d.LastModifiedUser)
                    .WithMany(p => p.DeviceAuditLastModifiedUser)
                    .HasForeignKey(d => d.LastModifiedUserId)
                    .HasConstraintName("FK_DeviceAudit_Users_LastModifiedUser");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.DeviceAudit)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_DeviceAudit_Site");
            });

            modelBuilder.Entity<DeviceAuditAlertFollowupHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditAlertId).HasColumnName("AuditAlertID");

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.FollowUpMessage)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeviceAuditAlerts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.DeviceAlarmTypeId).HasColumnName("DeviceAlarmTypeID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Hd).HasColumnName("HD");

                entity.Property(e => e.Na).HasColumnName("NA");

                entity.Property(e => e.Ps).HasColumnName("PS");

                entity.Property(e => e.ResolutionDate).HasColumnType("datetime");

                entity.Property(e => e.ResolutionNote)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ScheduleFollowUp).HasColumnType("datetime");

                entity.Property(e => e.SubdeviceStatuses)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<DeviceAuditFollowUp>(entity =>
            {
                entity.HasIndex(e => e.DeviceAuditItemId)
                    .HasName("IX_DeviceAuditFollowUp");

                entity.HasIndex(e => e.FollowUpDate)
                    .HasName("IX_DeviceAuditFollowUp_1");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.DeviceAuditFollowUp)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceAuditFollowUp_Users");

                entity.HasOne(d => d.DeviceAuditItem)
                    .WithMany(p => p.DeviceAuditFollowUp)
                    .HasForeignKey(d => d.DeviceAuditItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceAuditFollowUp_DeviceAuditItem");
            });

            modelBuilder.Entity<DeviceAuditItem>(entity =>
            {
                entity.HasIndex(e => e.DeviceAuditId)
                    .HasName("IX_DeviceAuditItem");

                entity.HasIndex(e => e.IsResolved)
                    .HasName("IX_DeviceAuditItem_1");

                entity.HasIndex(e => new { e.DeviceId, e.IsResolved })
                    .HasName("IX_DeviceAuditItem_3");

                entity.HasIndex(e => new { e.Attention, e.NotAvaible, e.HardDrive, e.PowerSupply, e.Missed })
                    .HasName("IX_DeviceAuditItem_2");

                entity.Property(e => e.ResolvedDate).HasColumnType("datetime");

                entity.HasOne(d => d.DeviceAudit)
                    .WithMany(p => p.DeviceAuditItem)
                    .HasForeignKey(d => d.DeviceAuditId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceAuditItem_DeviceAudit");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DeviceAuditItem)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeviceAuditItem_Device");
            });

            modelBuilder.Entity<DeviceBackup>(entity =>
            {
                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_DeviceBackup_DeviceID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Btype)
                    .HasColumnName("BType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.ExitCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeviceBusinessApps>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdditionalInfo)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Application)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            });

            modelBuilder.Entity<DeviceCactiGraph>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CactiName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.PathPrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceConfig>(entity =>
            {
                entity.Property(e => e.ApprovalComments).HasMaxLength(4000);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.DeviceConfig)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK_DeviceConfig_Users");

                entity.HasOne(d => d.DeviceConfigInfo)
                    .WithMany(p => p.DeviceConfig)
                    .HasForeignKey(d => d.DeviceConfigInfoId)
                    .HasConstraintName("FK_DeviceConfig_DeviceConfigInfo");
            });

            modelBuilder.Entity<DeviceConfigHistory>(entity =>
            {
                entity.Property(e => e.ApprovalComments).HasMaxLength(4000);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.ApprovedByNavigation)
                    .WithMany(p => p.DeviceConfigHistory)
                    .HasForeignKey(d => d.ApprovedBy)
                    .HasConstraintName("FK_DeviceConfigHistory_Users");

                entity.HasOne(d => d.DeviceConfigInfo)
                    .WithMany(p => p.DeviceConfigHistory)
                    .HasForeignKey(d => d.DeviceConfigInfoId)
                    .HasConstraintName("FK_DeviceConfigHistory_DeviceConfigInfo");
            });

            modelBuilder.Entity<DeviceConfigInfo>(entity =>
            {
                entity.Property(e => e.ConfigType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FwIp)
                    .HasColumnName("FW_IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FwName)
                    .HasColumnName("FW_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FwPassword)
                    .HasColumnName("FW_Password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FwPort)
                    .HasColumnName("FW_Port")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FwUser)
                    .HasColumnName("FW_User")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FwVdom)
                    .HasColumnName("FW_vdom")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastChecked)
                    .HasColumnName("_lastChecked")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DeviceConfigInfo)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_DeviceConfigInfo_Client");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DeviceConfigInfoCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_DeviceConfigInfo_Users");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.DeviceConfigInfo)
                    .HasForeignKey(d => d.DeviceId)
                    .HasConstraintName("FK_DeviceConfigInfo_Device");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.DeviceConfigInfoUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK_DeviceConfigInfo_Users1");
            });

            modelBuilder.Entity<DeviceCustomPerfCounter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomPerfCounterId).HasColumnName("CustomPerfCounterID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeviceCustomSqlsensor>(entity =>
            {
                entity.ToTable("DeviceCustomSQLSensor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConnectionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomSqlsensorId).HasColumnName("CustomSQLSensorID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.RiseAlertIfMore).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<DeviceEscallationProcedure>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.EscallationProcedure)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeviceHardwareStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeviceHeartbeatAlertLevels>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");
            });

            modelBuilder.Entity<DeviceHost>(entity =>
            {
                entity.HasIndex(e => e.DeviceId)
                    .HasName("IX_DeviceHosts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceLabel>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<DeviceMaintenance>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.OccurrencePeriodId).HasColumnName("OccurrencePeriodID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<DeviceNmsdevice>(entity =>
            {
                entity.HasKey(e => e.NmsdeviceId);

                entity.ToTable("DeviceNMSDevice");

                entity.Property(e => e.NmsdeviceId)
                    .HasColumnName("NMSDeviceId")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<DeviceSnmpcounter>(entity =>
            {
                entity.ToTable("DeviceSNMPCounter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommunityString)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Host)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeviceType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceType1)
                    .IsRequired()
                    .HasColumnName("DeviceType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceTypeDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Picture)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DiskDestructionLog>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DestroyedDate).HasColumnType("datetime");

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DiskDestructionLog)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiskDestructionLog_Client");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.DiskDestructionLogCreatedUser)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiskDestructionLog_Users");

                entity.HasOne(d => d.DestroyedByUser)
                    .WithMany(p => p.DiskDestructionLogDestroyedByUser)
                    .HasForeignKey(d => d.DestroyedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiskDestructionLog_Users1");
            });

            modelBuilder.Entity<Dnssensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("DNSSensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_DNSSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Domain)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.DocumentCategory)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.DocumentCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_DocumentCategory");
            });

            modelBuilder.Entity<DocumentCategory>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.DocumentCategoryNavigation)
                    .WithMany(p => p.InverseDocumentCategoryNavigation)
                    .HasForeignKey(d => d.DocumentCategoryId)
                    .HasConstraintName("FK_DocumentCategory_DocumentCategory");
            });

            modelBuilder.Entity<DocumentRecipient>(entity =>
            {
                entity.Property(e => e.ConfirmedDate).HasColumnType("datetime");

                entity.Property(e => e.OpenedDate).HasColumnType("datetime");

                entity.HasOne(d => d.DocumentVersion)
                    .WithMany(p => p.DocumentRecipient)
                    .HasForeignKey(d => d.DocumentVersionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentRecipient_DocumentVersion");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DocumentRecipient)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentRecipient_Users");
            });

            modelBuilder.Entity<DocumentVersion>(entity =>
            {
                entity.Property(e => e.ContentType).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.Url).HasMaxLength(500);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.DocumentVersion)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentVersion_Users");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.DocumentVersion)
                    .HasForeignKey(d => d.DocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentVersion_Document");
            });

            modelBuilder.Entity<DutyRotation>(entity =>
            {
                entity.Property(e => e.IsTl)
                    .HasColumnName("isTL")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.DutyRotation)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DutyRotation_Users");
            });

            modelBuilder.Entity<DutyRotationFinalize>(entity =>
            {
                entity.HasOne(d => d.DutyRotation)
                    .WithMany(p => p.DutyRotationFinalize)
                    .HasForeignKey(d => d.DutyRotationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DutyRotationFinalize_DutyRotation");
            });

            modelBuilder.Entity<DutyRotationNote>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.Text, e.CreatedDate, e.ParentDutyRotationNoteId, e.DutyRotationId, e.DutyRotationNoteTypeId, e.IsDeleted })
                    .HasName("IX_DutyRotationNote_DutyRotationId_DutyRotationNoteTypeId_IsDeleted");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Text).HasColumnType("nvarchar(max)");

                entity.HasOne(d => d.DutyRotation)
                    .WithMany(p => p.DutyRotationNote)
                    .HasForeignKey(d => d.DutyRotationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DutyRotationNote_DutyRotation");

                entity.HasOne(d => d.DutyRotationNoteType)
                    .WithMany(p => p.DutyRotationNote)
                    .HasForeignKey(d => d.DutyRotationNoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DutyRotationNote_DutyRotationNoteType");
            });

            modelBuilder.Entity<DutyRotationNoteType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DutyShifts>(entity =>
            {
                entity.HasIndex(e => e.DateEnd);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("dateEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("dateStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserUid)
                    .HasColumnName("UserUID")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DvContacts>(entity =>
            {
                entity.ToTable("DV_Contacts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Pattern)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DvCoverage>(entity =>
            {
                entity.ToTable("DV_Coverage");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DvEp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DV_EP");

                entity.Property(e => e.BackupContactEmail).HasColumnName("backup_contact_email");

                entity.Property(e => e.BackupContactName).HasColumnName("backup_contact_name");

                entity.Property(e => e.BackupContactPagerDuty).HasColumnName("backup_contact_pager_duty");

                entity.Property(e => e.BackupContactPhone).HasColumnName("backup_contact_phone");

                entity.Property(e => e.ContactEmail).HasColumnName("contact_email");

                entity.Property(e => e.ContactName).HasColumnName("contact_name");

                entity.Property(e => e.ContactPagerDuty).HasColumnName("contact_pager_duty");

                entity.Property(e => e.ContactPhone).HasColumnName("contact_phone");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.WaitFor).HasColumnName("wait_for");
            });

            modelBuilder.Entity<DvEp20130814>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DV_EP_2013_08_14");

                entity.Property(e => e.BackupContactEmail).HasColumnName("backup_contact_email");

                entity.Property(e => e.BackupContactName).HasColumnName("backup_contact_name");

                entity.Property(e => e.BackupContactPagerDuty).HasColumnName("backup_contact_pager_duty");

                entity.Property(e => e.BackupContactPhone).HasColumnName("backup_contact_phone");

                entity.Property(e => e.ContactEmail).HasColumnName("contact_email");

                entity.Property(e => e.ContactName).HasColumnName("contact_name");

                entity.Property(e => e.ContactPagerDuty).HasColumnName("contact_pager_duty");

                entity.Property(e => e.ContactPhone).HasColumnName("contact_phone");

                entity.Property(e => e.Priority).HasColumnName("priority");
            });

            modelBuilder.Entity<DvEpNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DV_EP_NEW");

                entity.Property(e => e.BackupContactEmail).HasColumnName("backup_contact_email");

                entity.Property(e => e.BackupContactName).HasColumnName("backup_contact_name");

                entity.Property(e => e.BackupContactPagerDuty).HasColumnName("backup_contact_pager_duty");

                entity.Property(e => e.BackupContactPhone).HasColumnName("backup_contact_phone");

                entity.Property(e => e.ContactEmail).HasColumnName("contact_email");

                entity.Property(e => e.ContactName).HasColumnName("contact_name");

                entity.Property(e => e.ContactPagerDuty).HasColumnName("contact_pager_duty");

                entity.Property(e => e.ContactPhone).HasColumnName("contact_phone");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.WaitFor).HasColumnName("wait_for");
            });

            modelBuilder.Entity<EmailDump>(entity =>
            {
                entity.Property(e => e.Bcc)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Body).HasColumnType("text");

                entity.Property(e => e.BodyFormat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.From)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ReplyTo)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TextBody)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.EmailDump)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK_EmailDump_Ticket");
            });

            modelBuilder.Entity<EmailDumpAntiDups>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.Property(e => e.MessageId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EmailDumpAttachment>(entity =>
            {
                entity.Property(e => e.AttachmentData).HasColumnType("image");

                entity.Property(e => e.AttachmentName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.EmailDumpAttachment)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK_EmailDumpAttachment_Ticket");
            });

            modelBuilder.Entity<EmailDumpAttachmentBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmailDumpAttachment_back");

                entity.Property(e => e.AttachmentData).HasColumnType("image");

                entity.Property(e => e.AttachmentName)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailDumpAttachmentId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<EmailRecipients>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmcLuns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMC_Luns");

                entity.Property(e => e.Emcid)
                    .HasColumnName("EMCID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('OLDEMC')");

                entity.Property(e => e.LunName)
                    .HasColumnName("LUN Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LunNumber).HasColumnName("LUN Number");

                entity.Property(e => e.RaidType)
                    .HasColumnName("RAID Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoragePool)
                    .HasColumnName("Storage Pool")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmcRaidGroups>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMC_RaidGroups");

                entity.Property(e => e.ContiguousFreeSpaceGb).HasColumnName("Contiguous Free Space (GB)");

                entity.Property(e => e.Emcid)
                    .HasColumnName("EMCID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('OLDEMC')");

                entity.Property(e => e.FreeSpaceGb).HasColumnName("Free Space (GB)");

                entity.Property(e => e.Luns)
                    .HasColumnName("LUNs")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RaidGroupId).HasColumnName("RAID Group ID");

                entity.Property(e => e.RaidType)
                    .HasColumnName("RAID Type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalSpaceGb).HasColumnName("Total Space (GB)");
            });

            modelBuilder.Entity<EmcStorageGroups>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EMC_StorageGroups");

                entity.Property(e => e.AttachedServers)
                    .HasColumnName("Attached Servers")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Emcid)
                    .HasColumnName("EMCID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Luns)
                    .HasColumnName("LUNs")
                    .IsUnicode(false);

                entity.Property(e => e.StorageGroupName)
                    .HasColumnName("Storage Group Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Department)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCell)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneHome)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneOffice)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VcardAttachmentId).HasColumnName("VcardAttachmentID");
            });

            modelBuilder.Entity<EngineeringTaskStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Status)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Task)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.EngineeringTaskStatus)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngineeringTaskStatus_Client");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.EngineeringTaskStatus)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_EngineeringTaskStatus_ProjectID");

                entity.HasOne(d => d.SeverityNavigation)
                    .WithMany(p => p.EngineeringTaskStatus)
                    .HasForeignKey(d => d.Severity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EngineeringTaskStatus_Severity");
            });

            modelBuilder.Entity<Escalation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<EscalationContactGroups>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackupContact)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phones)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EscalationContactGroupsHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.BackupContact)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phones)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EscalationContacts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phones)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Skype)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Team)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EscalationHostGroups>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HostGroup)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EscalationHostGroupsHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HostGroup)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EscalationProcedureStatisticsHistory>(entity =>
            {
                entity.ToTable("EscalationProcedureStatistics_History");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateofReview)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.EscalationProcedureStatisticsHistoryCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EscalationProcedureStatistics_History_Creator");

                entity.HasOne(d => d.ReviewerNavigation)
                    .WithMany(p => p.EscalationProcedureStatisticsHistoryReviewerNavigation)
                    .HasForeignKey(d => d.Reviewer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EscalationProcedureStatistics_History_Reviewer");
            });

            modelBuilder.Entity<EscalationProcedureStatisticsOverseers>(entity =>
            {
                entity.ToTable("EscalationProcedureStatistics_Overseers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.EscalationProcedureStatisticsOverseers)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EscalationProcedureStatistics_Overseers_Username");
            });

            modelBuilder.Entity<EscalationProcedureStatisticsProcedureCreators>(entity =>
            {
                entity.ToTable("EscalationProcedureStatistics_ProcedureCreators");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.EscalationProcedureStatisticsProcedureCreators)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EscalationProcedureStatistics_ProcedureCreators_Username");
            });

            modelBuilder.Entity<EscalationServices>(entity =>
            {
                entity.HasIndex(e => new { e.Host, e.HostGroup, e.Service })
                    .HasName("UNQ_Host_HostGroup_Service")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Alert).HasMaxLength(4000);

                entity.Property(e => e.Area).HasMaxLength(4000);

                entity.Property(e => e.BacklogRelated)
                    .HasColumnName("Backlog Related")
                    .HasMaxLength(4000);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Component).HasMaxLength(4000);

                entity.Property(e => e.Contact).HasMaxLength(4000);

                entity.Property(e => e.ContactGroup1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactGroup2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactGroup3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactMethod)
                    .HasColumnName("contact method")
                    .HasMaxLength(4000);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(4000);

                entity.Property(e => e.Frequency).HasMaxLength(4000);

                entity.Property(e => e.Host).HasMaxLength(100);

                entity.Property(e => e.HostGroup).HasMaxLength(100);

                entity.Property(e => e.Info).HasMaxLength(4000);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Meaning)
                    .HasColumnName("meaning")
                    .HasMaxLength(4000);

                entity.Property(e => e.MonitorType)
                    .HasColumnName("Monitor Type")
                    .HasMaxLength(4000);

                entity.Property(e => e.Query).HasMaxLength(4000);

                entity.Property(e => e.Recomndation).HasMaxLength(4000);

                entity.Property(e => e.Service)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Sev)
                    .HasColumnName("SEV")
                    .HasMaxLength(4000);

                entity.Property(e => e.Sop)
                    .HasColumnName("SOP")
                    .HasMaxLength(4000);

                entity.Property(e => e.Usage).HasMaxLength(4000);
            });

            modelBuilder.Entity<EscalationServicesHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.Alert).HasMaxLength(4000);

                entity.Property(e => e.Area).HasMaxLength(4000);

                entity.Property(e => e.BacklogRelated)
                    .HasColumnName("Backlog Related")
                    .HasMaxLength(4000);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Component).HasMaxLength(4000);

                entity.Property(e => e.Contact).HasMaxLength(4000);

                entity.Property(e => e.ContactGroup1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactGroup2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactGroup3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactMethod)
                    .HasColumnName("contact method")
                    .HasMaxLength(4000);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(4000);

                entity.Property(e => e.Frequency).HasMaxLength(4000);

                entity.Property(e => e.Host).HasMaxLength(100);

                entity.Property(e => e.HostGroup).HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Info).HasMaxLength(4000);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Meaning)
                    .HasColumnName("meaning")
                    .HasMaxLength(4000);

                entity.Property(e => e.MonitorType)
                    .HasColumnName("Monitor Type")
                    .HasMaxLength(4000);

                entity.Property(e => e.Query).HasMaxLength(4000);

                entity.Property(e => e.Recomndation).HasMaxLength(4000);

                entity.Property(e => e.Service)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.Sev)
                    .HasColumnName("SEV")
                    .HasMaxLength(4000);

                entity.Property(e => e.Sop)
                    .HasColumnName("SOP")
                    .HasMaxLength(4000);

                entity.Property(e => e.Usage).HasMaxLength(4000);
            });

            modelBuilder.Entity<ExecUpdateDev>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompletedProjects).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DelayedProjectsClient).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DelayedProjectsDe)
                    .HasColumnName("DelayedProjectsDE")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DepartmentChange).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DepartmentRating).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ManagementHoursSpent).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ManagementHoursUpcoming).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NumberofProjects).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.OpsTicketHoursSpent).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.OpsTicketHoursUpcoming).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.OverallDepartmentRatingbyManager).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ProjectHoursOverAllowedLimit).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ProjectHoursSpent).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ProjectHoursUpcoming).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Qahours)
                    .HasColumnName("QAHours")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Resources).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Schedule).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TimeFrame)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDelayedProjects).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TotalHoursSpent).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TotalHoursUpcoming).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ExecUpdateNotes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.ParamRefName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExecUpdateOps>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentChange).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DepartmentRating).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DisclosureOfDedata)
                    .HasColumnName("DisclosureOfDEData")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DisclosureofClientsData).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Failuresofclientfacingissueshandling74).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Globalfailures72).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NoExperienceResolved).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NoInfoResolved).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NumberofInterviews).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NumberofOffers).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NumberofOpenedPositions).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NumberofOperationalMistakesRem).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NumberofOperationalMistakesUs)
                    .HasColumnName("NumberofOperationalMistakesUS")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.OverallDepartmentRatingbyManager).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Partialfailures73).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.RemoteOfficeCannotOperateNoExp).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.RemoteOfficeCannotOperateNoInfo).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.RemoteOpsRating).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.RemoteTeamLoad).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ServiceInterruptionOfClients).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ServiceInterruptionOfDe)
                    .HasColumnName("ServiceInterruptionOfDE")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TimeFrame)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UnAuthAccessToClients).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.UnAuthAccessToDe)
                    .HasColumnName("UnAuthAccessToDE")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.UsopsRating)
                    .HasColumnName("USOpsRating")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.UsteamLoad)
                    .HasColumnName("USTeamLoad")
                    .HasColumnType("decimal(20, 5)");
            });

            modelBuilder.Entity<ExecUpdateProjects>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmberAlert75).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.CompletedProjects).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DelayedProjectsClient).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DelayedProjectsDe)
                    .HasColumnName("DelayedProjectsDE")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DepartmentChange).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.DepartmentRating).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ManagementHoursSpent).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ManagementHoursUpcoming).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NumberofProjects).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.NumberofProjectsWorkedOn).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.OpsTicketHoursSpent).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.OpsTicketHoursUpcoming).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.OverallDepartmentRatingbyManager).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ProjNumberofProjectsUpcomingWeek).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ProjectHoursSpent).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ProjectHoursUpcoming).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ProjectsActualHours77).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.ProjectsPlannedHours76).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Resources).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Schedule).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TimeFrame)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimePerformanceIndexTpi78)
                    .HasColumnName("TimePerformanceIndexTPI78")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TimePerformanceindexTpigreen79)
                    .HasColumnName("TimePerformanceindexTPIGreen79")
                    .HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TotalDelayedProjects).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TotalHoursSpent).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.TotalHoursUpcoming).HasColumnType("decimal(20, 5)");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ExecUpdateSetDefinitions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SetName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExecUpdateSubsetDefinitions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ParamRef)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubsetName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.SetRefNavigation)
                    .WithMany(p => p.ExecUpdateSubsetDefinitions)
                    .HasForeignKey(d => d.SetRef)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExecUpdateSubsetDef_SetRef");
            });

            modelBuilder.Entity<Ftpsensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("FTPSensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_FTPSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConnectionTimeOut).HasDefaultValueSql("((30))");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ftpaddress)
                    .IsRequired()
                    .HasColumnName("FTPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.Port).HasDefaultValueSql("((1433))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GlobalSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Value2)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeartBeat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HelpDeskDutyShifts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateEnd)
                    .HasColumnName("dateEnd")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStart)
                    .HasColumnName("dateStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserUid)
                    .HasColumnName("UserUID")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hrmanager>(entity =>
            {
                entity.ToTable("HRManager");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Uid).HasColumnName("UID");
            });

            modelBuilder.Entity<HrmanagerEmployee>(entity =>
            {
                entity.ToTable("HRManagerEmployee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserIdEmployee).HasColumnName("UserID_Employee");

                entity.Property(e => e.UserIdManager).HasColumnName("UserID_Manager");
            });

            modelBuilder.Entity<Httpsensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__HTTPSensor__7BD05397")
                    .IsClustered(false);

                entity.ToTable("HTTPSensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_HTTPSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConnectionTimeOut).HasDefaultValueSql("((30))");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.Httprequest)
                    .IsRequired()
                    .HasColumnName("HTTPRequest")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.Port).HasDefaultValueSql("((80))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Icmpsensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__ICMPSensor__75235608")
                    .IsClustered(false);

                entity.ToTable("ICMPSensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_ICMPSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.HostId)
                    .HasColumnName("HostID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.PacketSize).HasDefaultValueSql("((32))");

                entity.Property(e => e.SuccessRate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.Icmpsensor)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_ICMPSensor_ICMPSensorHost");
            });

            modelBuilder.Entity<IcmpsensorHost>(entity =>
            {
                entity.ToTable("ICMPSensorHost");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassKey)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IcmpsensorOldmonitor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ICMPSensor_OLDMonitor");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<IgnoreDiskVolume>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VolumeName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncidentMain>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdminActionComm).IsUnicode(false);

                entity.Property(e => e.BriefIncident).IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeTitle).IsUnicode(false);

                entity.Property(e => e.EventDescription).IsUnicode(false);

                entity.Property(e => e.EventLocation).IsUnicode(false);

                entity.Property(e => e.EventOccurred).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ManagementComments).IsUnicode(false);

                entity.Property(e => e.ManagerTitle).IsUnicode(false);

                entity.Property(e => e.ManagerUpdated).HasColumnType("datetime");

                entity.Property(e => e.UnsatisfactoryComm).IsUnicode(false);

                entity.HasOne(d => d.RiskAssetTypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RiskAssetType)
                    .HasConstraintName("FK_IncidentMain_RiskAssetType");

                entity.HasOne(d => d.RiskNameNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RiskName)
                    .HasConstraintName("FK_IncidentMain_RiskName");

                entity.HasOne(d => d.RiskTypeNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.RiskType)
                    .HasConstraintName("FK_IncidentMain_RiskType");
            });

            modelBuilder.Entity<IncidentRev>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RevId).HasColumnName("RevID");

                entity.Property(e => e.StatusUpdateMessage).IsUnicode(false);
            });

            modelBuilder.Entity<IncomingTexts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneFrom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneTo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InsidePortSensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__InsidePortSensor__22EA20B8")
                    .IsClustered(false);

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_InsidePortSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.InsidePortName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InsidePortTypeId).HasColumnName("InsidePortTypeID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InsidePortType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InternalAudit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.AuditPersonId).HasColumnName("AuditPersonID");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.EndAfterDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasDefaultValueSql("('23:59:59')");

                entity.Property(e => e.LastAuditDate).HasColumnType("datetime");

                entity.Property(e => e.Schedule).HasMaxLength(64);

                entity.Property(e => e.StartAuditDate).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.InternalAudit)
                    .HasForeignKey(d => d.Client)
                    .HasConstraintName("FK_InternalAudit_Client");
            });

            modelBuilder.Entity<InternalAuditRecordFiles>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.File).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InternalAuditRecordId).HasColumnName("InternalAuditRecordID");

                entity.HasOne(d => d.InternalAuditRecord)
                    .WithMany(p => p.InternalAuditRecordFiles)
                    .HasForeignKey(d => d.InternalAuditRecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InternalAuditRecordFiles_InternalAuditRecordID");
            });

            modelBuilder.Entity<InternalAuditRecords>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuditorId).HasColumnName("AuditorID");

                entity.Property(e => e.Comments).HasMaxLength(4000);

                entity.Property(e => e.DateConducted).HasColumnType("datetime");

                entity.Property(e => e.InternalAuditId).HasColumnName("InternalAuditID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InternalVendor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContractEnd).HasColumnType("datetime");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<InvApplication>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.InvApplication)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_InvApplication_Client");
            });

            modelBuilder.Entity<InvComponent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApplicationId).HasColumnName("ApplicationID");

                entity.Property(e => e.Configuration).HasColumnType("text");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.Startup).HasColumnType("text");

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.InvComponent)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvComponent_InvApplication");
            });

            modelBuilder.Entity<InvComponentDbinstance>(entity =>
            {
                entity.ToTable("InvComponentDBInstance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComponentId).HasColumnName("ComponentID");

                entity.Property(e => e.Databases)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.DbinstanceId).HasColumnName("DBInstanceID");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.InvComponentDbinstance)
                    .HasForeignKey(d => d.ComponentId)
                    .HasConstraintName("FK_InvComponentDBInstance_InvComponent");

                entity.HasOne(d => d.Dbinstance)
                    .WithMany(p => p.InvComponentDbinstance)
                    .HasForeignKey(d => d.DbinstanceId)
                    .HasConstraintName("FK_InvComponentDBInstance_DBInstance");
            });

            modelBuilder.Entity<InvComponentDevice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ComponentId).HasColumnName("ComponentID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.DeviceRoleId).HasColumnName("DeviceRoleID");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.InvComponentDevice)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvComponentDevice_InvComponent");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.InvComponentDevice)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvComponentDevice_Device");

                entity.HasOne(d => d.DeviceRole)
                    .WithMany(p => p.InvComponentDevice)
                    .HasForeignKey(d => d.DeviceRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvComponentDevice_InvDeviceRole");
            });

            modelBuilder.Entity<InvDeviceRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IsoMonitoringHistoryMain>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RevId).HasColumnName("RevID");

                entity.Property(e => e.StatusUpdateMessage).IsUnicode(false);

                entity.HasOne(d => d.Rev)
                    .WithMany()
                    .HasForeignKey(d => d.RevId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ISOHistoryMain_RevID");
            });

            modelBuilder.Entity<IsoMonitoringHistoryMonth>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RevId).HasColumnName("RevID");

                entity.Property(e => e.StatusUpdateMessage).IsUnicode(false);

                entity.HasOne(d => d.Rev)
                    .WithMany()
                    .HasForeignKey(d => d.RevId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ISOHistoryMonth_RevID");
            });

            modelBuilder.Entity<IsoMonitoringMain>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.WhatToMonitor).IsUnicode(false);
            });

            modelBuilder.Entity<IsoMonitoringMonth>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MainId).HasColumnName("MainID");

                entity.Property(e => e.WhoEvalObserv).IsUnicode(false);

                entity.Property(e => e.WhoObserv).IsUnicode(false);

                entity.HasOne(d => d.Main)
                    .WithMany(p => p.IsoMonitoringMonth)
                    .HasForeignKey(d => d.MainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MainID");
            });

            modelBuilder.Entity<Kbarticles>(entity =>
            {
                entity.ToTable("KBArticles");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KbarticlesToCategories>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.ArticleId });

                entity.ToTable("KBArticlesToCategories");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");
            });

            modelBuilder.Entity<Kbcategories>(entity =>
            {
                entity.ToTable("KBCategories");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kmatapes>(entity =>
            {
                entity.ToTable("KMATapes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngineerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted0)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Inserted9)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed0)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed6)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed7)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed8)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Removed9)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time5)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AlertPattern)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.DevicePattern)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.RecurTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.RecurTimeTo).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Maintenance20180217>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Maintenance_20180217");

                entity.Property(e => e.AlertPattern)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.DevicePattern)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.RecurTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.RecurTimeTo).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaintenanceOccurrencePeriod>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Id)
                    .HasName("UQ__MaintenanceOccur__4E498009")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedicalHours>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TotalAlloted).HasDefaultValueSql("((56))");

                entity.Property(e => e.TotalLeft).HasComputedColumnSql("(((((((((((([TotalAlloted]-[Jan])-[feb])-[Mar])-[Apr])-[May])-[Jun])-[Jul])-[Aug])-[Sep])-[Oct])-[Nov])-[Dec])");

                entity.Property(e => e.TotalUsed).HasComputedColumnSql("((((((((((([Jan]+[Feb])+[Mar])+[Apr])+[May])+[Jun])+[Jul])+[Aug])+[Sep])+[Oct])+[Nov])+[Dec])");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MeetingTypeId).HasColumnName("MeetingTypeID");
            });

            modelBuilder.Entity<MeetingAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingId).HasColumnName("MeetingID");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MeetingType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Miketest>(entity =>
            {
                entity.ToTable("miketest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Htmlmessage)
                    .HasColumnName("htmlmessage")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MonitorerHeartBeat>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SessionStarted).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MonitoringAdjustments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.Modifier)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.PalId).HasColumnName("PalID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MonitoringHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.MonitoringHistory)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MonitoringHistoryClient");
            });

            modelBuilder.Entity<MySqlsensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__MySQLSensor__10CB707D")
                    .IsClustered(false);

                entity.ToTable("MySQLSensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_MySQLSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConnectionTimeOut).HasDefaultValueSql("((30))");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.MySqlserver)
                    .IsRequired()
                    .HasColumnName("MySQLServer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Port).HasDefaultValueSql("((1433))");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("PWD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlstatement)
                    .IsRequired()
                    .HasColumnName("SQLStatement")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NetworkMaps>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MapFile)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.NetworkMaps)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK_NetworkMaps_Users");
            });

            modelBuilder.Entity<NoSha256Devices>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("__NO_SHA256_Devices");

                entity.Property(e => e.Deviceid).HasColumnName("deviceid");
            });

            modelBuilder.Entity<Oraclesensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__ORACLESensor__0A1E72EE")
                    .IsClustered(false);

                entity.ToTable("ORACLESensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_ORACLESensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConnectionTimeOut).HasDefaultValueSql("((30))");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.Oracletns)
                    .IsRequired()
                    .HasColumnName("ORACLETNS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Port).HasDefaultValueSql("((1433))");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("PWD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sid)
                    .IsRequired()
                    .HasColumnName("SID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlstatement)
                    .IsRequired()
                    .HasColumnName("SQLStatement")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ossec>(entity =>
            {
                entity.ToTable("OSSEC");

                entity.HasIndex(e => e.Status);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AssetId).HasColumnName("AssetID");

                entity.Property(e => e.Body)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OutgoingTexts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneFrom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneTo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SendLog).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PartnersPortal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientLogin)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ClientLoginId).HasColumnName("ClientLoginID");

                entity.Property(e => e.Closed)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateLastUpdated).HasColumnType("datetime");

                entity.Property(e => e.DealLocation)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DeclineReason).HasColumnType("text");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.EstimatedTimeframe).HasColumnType("datetime");

                entity.Property(e => e.Paid)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryContact)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryContactEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryContact)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryContactEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServicesRequired)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<PasswordAccessLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessType)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserIp)
                    .IsRequired()
                    .HasColumnName("UserIP")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Passwords>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Access)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Deleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryPassword)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryUserName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PerformanceAlertLevels>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cpualert)
                    .HasColumnName("CPUAlert")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.Cpumax)
                    .HasColumnName("CPUMax")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.Cpumin)
                    .HasColumnName("CPUMin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CpuqueueAlert)
                    .HasColumnName("CPUQueueAlert")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.CpuqueueMax)
                    .HasColumnName("CPUQueueMax")
                    .HasDefaultValueSql("((1000))");

                entity.Property(e => e.CpuqueueMin)
                    .HasColumnName("CPUQueueMin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CpuqueueWarning)
                    .HasColumnName("CPUQueueWarning")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.Cpuwarning)
                    .HasColumnName("CPUWarning")
                    .HasDefaultValueSql("((80))");

                entity.Property(e => e.DbvolumeUtilizationAlert).HasColumnName("DBVolumeUtilizationAlert");

                entity.Property(e => e.DbvolumeUtilizationMax).HasColumnName("DBVolumeUtilizationMax");

                entity.Property(e => e.DbvolumeUtilizationMin).HasColumnName("DBVolumeUtilizationMin");

                entity.Property(e => e.DbvolumeUtilizationWarning).HasColumnName("DBVolumeUtilizationWarning");

                entity.Property(e => e.DiskloadAlert)
                    .HasColumnName("DISKLoadAlert")
                    .HasDefaultValueSql("((90))");

                entity.Property(e => e.DiskloadMax)
                    .HasColumnName("DISKLoadMax")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.DiskloadMin)
                    .HasColumnName("DISKLoadMin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DiskloadWarning)
                    .HasColumnName("DISKLoadWarning")
                    .HasDefaultValueSql("((80))");

                entity.Property(e => e.MemAlert).HasDefaultValueSql("((90))");

                entity.Property(e => e.MemMax).HasDefaultValueSql("((100))");

                entity.Property(e => e.MemMin).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemWarning).HasDefaultValueSql("((80))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VolumeUtilizationAlert).HasDefaultValueSql("((95))");

                entity.Property(e => e.VolumeUtilizationMax).HasDefaultValueSql("((100))");

                entity.Property(e => e.VolumeUtilizationMin).HasDefaultValueSql("((0))");

                entity.Property(e => e.VolumeUtilizationWarning).HasDefaultValueSql("((80))");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermissionClientLogin>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.PermissionClientLogin)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionClientLogin_Client");

                entity.HasOne(d => d.ClientLogin)
                    .WithMany(p => p.PermissionClientLogin)
                    .HasForeignKey(d => d.ClientLoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionClientLogin_ClientLogin");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionClientLogin)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionClientLogin_Permission");
            });

            modelBuilder.Entity<PostgreSqlsensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__PostgreSQLSensor")
                    .IsClustered(false);

                entity.ToTable("PostgreSQLSensor");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatabaseName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.HostIp)
                    .HasColumnName("HostIP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProcessToDevice>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__ProcessToDevice__2F1AED73")
                    .IsClustered(false);

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_ProcessToDevice_DeviceID")
                    .IsClustered();

                entity.HasIndex(e => e.ProcessId)
                    .HasName("IDX_ProcessToDevice_ProcessID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.HeartBeatId).HasColumnName("HeartBeatID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TsOfCurrentStatus)
                    .HasColumnName("tsOfCurrentStatus")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectNotes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(4096)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProjectTrackingId).HasColumnName("ProjectTrackingID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ProjectPriority>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PriorityName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectResourceActual>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OtherProject)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ReportedDate).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectResourceActual)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ProjectResourceActual_ProjectID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectResourceActual)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectResourceActual_UserID");
            });

            modelBuilder.Entity<ProjectResourcePlanning>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedByUserId).HasColumnName("PlannedByUserID");

                entity.Property(e => e.PlannedForUserId).HasColumnName("PlannedForUserID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.PlannedByUser)
                    .WithMany(p => p.ProjectResourcePlanningPlannedByUser)
                    .HasForeignKey(d => d.PlannedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectResourcePlanning_PlannedByUserID");

                entity.HasOne(d => d.PlannedForUser)
                    .WithMany(p => p.ProjectResourcePlanningPlannedForUser)
                    .HasForeignKey(d => d.PlannedForUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectResourcePlanning_PlannedForUserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectResourcePlanning)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectResourcePlanning_ProjectID");
            });

            modelBuilder.Entity<ProjectStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectTracking>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientPmName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DePmId).HasColumnName("DePmID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusAdminId).HasColumnName("StatusAdminID");
            });

            modelBuilder.Entity<ProjectTrackingAction>(entity =>
            {
                entity.HasIndex(e => e.SubProjectId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonResponsibleId).HasColumnName("PersonResponsibleID");

                entity.Property(e => e.Risk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDescription).IsUnicode(false);

                entity.Property(e => e.SubProjectId).HasColumnName("SubProjectID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ProjectTrackingAction)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK_ProjectTrackingAction_Users");
            });

            modelBuilder.Entity<ProjectTrackingContractDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractDetailId).HasColumnName("ContractDetailID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectTrackingDocuments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MapFile)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectTrackingId).HasColumnName("ProjectTrackingID");
            });

            modelBuilder.Entity<ProjectTrackingFacilities>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectTrackingProjectId).HasColumnName("ProjectTrackingProjectID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UsfacilitiesId).HasColumnName("USFacilitiesID");
            });

            modelBuilder.Entity<ProjectTrackingOld>(entity =>
            {
                entity.ToTable("ProjectTracking_old");

                entity.HasIndex(e => e.ParentId)
                    .HasName("IDX_ProjectTracking_ParentID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientPmName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DePmId).HasColumnName("DePmID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusAdminId).HasColumnName("StatusAdminID");
            });

            modelBuilder.Entity<ProjectTrackingProject>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedByOs).HasColumnName("ApprovedByOS");

                entity.Property(e => e.ApprovedByPm).HasColumnName("ApprovedByPM");

                entity.Property(e => e.ApprovedByTl).HasColumnName("ApprovedByTL");

                entity.Property(e => e.Architecture).HasColumnType("image");

                entity.Property(e => e.Attn)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CloseNotificationOs)
                    .HasColumnName("CloseNotificationOS")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CloseNotificationPm)
                    .HasColumnName("CloseNotificationPM")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ClosedByOs).HasColumnName("ClosedByOS");

                entity.Property(e => e.ClosedByPm).HasColumnName("ClosedByPM");

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.HardWare).IsUnicode(false);

                entity.Property(e => e.HasToBeConfirmByClientDeliveryDate)
                    .HasColumnName("HasToBeConfirmByClient_DeliveryDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ImplementationOther)
                    .HasColumnName("implementationOther")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsHardDeliveryDate)
                    .HasColumnName("IsHard_DeliveryDate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsImplementationOther).HasColumnName("isImplementationOther");

                entity.Property(e => e.IsInstallations).HasColumnName("isInstallations");

                entity.Property(e => e.IsKnowledgeAssistance).HasColumnName("isKnowledgeAssistance");

                entity.Property(e => e.IsLocationOther).HasColumnName("isLocationOther");

                entity.Property(e => e.IsMigration).HasColumnName("isMigration");

                entity.Property(e => e.IsProjectManagement).HasColumnName("isProjectManagement");

                entity.Property(e => e.IsSetupConfigurations).HasColumnName("isSetupConfigurations");

                entity.Property(e => e.IsTesting).HasColumnName("isTesting");

                entity.Property(e => e.LocationOther)
                    .HasColumnName("locationOther")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OnScheduleColor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PersonResponsibleId).HasColumnName("PersonResponsibleID");

                entity.Property(e => e.ResourcesColor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityNotes).IsUnicode(false);

                entity.Property(e => e.SoftWare).IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusColor)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProjectTrackingProjectStatementOfCompletionFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.File).IsRequired();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ptpref).HasColumnName("PTPRef");

                entity.HasOne(d => d.PtprefNavigation)
                    .WithMany(p => p.ProjectTrackingProjectStatementOfCompletionFile)
                    .HasForeignKey(d => d.Ptpref)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectTrackingProjectStatementOfCompletionFile_ID");
            });

            modelBuilder.Entity<ProjectTrackingSubProject>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersonResponsibleId).HasColumnName("PersonResponsibleID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDescription).IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasComputedColumnSql("(getdate())");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ProjectTrackingSubProject)
                    .HasForeignKey(d => d.CreatedUserId)
                    .HasConstraintName("FK_ProjectTrackingSubProject_Users");
            });

            modelBuilder.Entity<ProjectTrackingTicket>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TicketId).HasColumnName("TicketID");
            });

            modelBuilder.Entity<ProjectTrackingTicketAction>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");
            });

            modelBuilder.Entity<ProjectTrackingTicketSubproject>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SubprojectId).HasColumnName("SubprojectID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDevHours)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.AmountApproved).HasColumnType("money");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.DateRecieved).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DevHours1).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DevHours2).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DevHours3).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DevHoursEstimate)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DevMoney1).HasColumnType("money");

                entity.Property(e => e.DevMoney2).HasColumnType("money");

                entity.Property(e => e.DevMoney3).HasColumnType("money");

                entity.Property(e => e.EstimatedEndDate).HasColumnType("datetime");

                entity.Property(e => e.FeeToClient)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.HoursToClient)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pm1)
                    .HasColumnName("PM1")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pm2)
                    .HasColumnName("PM2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pm3)
                    .HasColumnName("PM3")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Pmhours1)
                    .HasColumnName("PMHours1")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Pmhours2)
                    .HasColumnName("PMHours2")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Pmhours3)
                    .HasColumnName("PMHours3")
                    .HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PmtaskList1)
                    .HasColumnName("PMTaskList1")
                    .IsUnicode(false);

                entity.Property(e => e.PmtaskList2)
                    .HasColumnName("PMTaskList2")
                    .IsUnicode(false);

                entity.Property(e => e.PmtaskList3)
                    .HasColumnName("PMTaskList3")
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeApproved).HasColumnType("datetime");

                entity.Property(e => e.ScopeComplete).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatsPmfee)
                    .HasColumnName("StatsPMFee")
                    .HasColumnType("money");

                entity.Property(e => e.StatsStatedFee).HasColumnType("money");

                entity.Property(e => e.StatsStatedHours).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskList1).IsUnicode(false);

                entity.Property(e => e.TaskList2).IsUnicode(false);

                entity.Property(e => e.TaskList3).IsUnicode(false);

                entity.Property(e => e.TeamName1)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName2)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName3)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDevHours).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalPmhours)
                    .HasColumnName("TotalPMHours")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Quotes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Document).IsRequired();

                entity.Property(e => e.DocumentName)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.LastUpdatedBy)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.LastUpdatedOn)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Quoteno)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UploadedBy)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UploadedOn)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<RecuringTicket>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).IsRequired();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClassNavigation)
                    .WithMany(p => p.RecuringTicket)
                    .HasForeignKey(d => d.Class)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecuringTicketClass");

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.RecuringTicket)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecuringTicketClient");

                entity.HasOne(d => d.CreatorNavigation)
                    .WithMany(p => p.RecuringTicketCreatorNavigation)
                    .HasForeignKey(d => d.Creator)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecuringTicketCreator");

                entity.HasOne(d => d.ExecutorNavigation)
                    .WithMany(p => p.RecuringTicketExecutorNavigation)
                    .HasForeignKey(d => d.Executor)
                    .HasConstraintName("FK_RecuringTicketExecutor");
            });

            modelBuilder.Entity<RecuringTicketInstance>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.RecuringTicketNavigation)
                    .WithMany(p => p.RecuringTicketInstance)
                    .HasForeignKey(d => d.RecuringTicket)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecuringTicketInstanceRecuringTicket");

                entity.HasOne(d => d.TicketNavigation)
                    .WithMany(p => p.RecuringTicketInstance)
                    .HasForeignKey(d => d.Ticket)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecuringTicketInstanceTicket");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.GeneratedOn).HasColumnType("datetime");

                entity.Property(e => e.Instance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ReportTemplate)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.ReportTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Report_ReportTemplate");
            });

            modelBuilder.Entity<ReportData>(entity =>
            {
                entity.Property(e => e.TextData).IsUnicode(false);

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportData)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportData_Report");

                entity.HasOne(d => d.ReportTemplateSection)
                    .WithMany(p => p.ReportData)
                    .HasForeignKey(d => d.ReportTemplateSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportData_ReportTemplateSection");
            });

            modelBuilder.Entity<ReportTemplate>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportTemplateSection>(entity =>
            {
                entity.Property(e => e.Flow)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Full')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlquery)
                    .HasColumnName("SQLQuery")
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ReportTemplate)
                    .WithMany(p => p.ReportTemplateSection)
                    .HasForeignKey(d => d.ReportTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateSection_ReportTemplate");

                entity.HasOne(d => d.ReportTemplateSectionType)
                    .WithMany(p => p.ReportTemplateSection)
                    .HasForeignKey(d => d.ReportTemplateSectionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTemplateSection_ReportTemplateSectionType");
            });

            modelBuilder.Entity<ReportTemplateSectionType>(entity =>
            {
                entity.Property(e => e.ReportTemplateSectionTypeId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rumccalls>(entity =>
            {
                entity.ToTable("RUMCCalls");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Ticket)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Rumccalls)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RUMCCallsStatus_1");
            });

            modelBuilder.Entity<RumccallsStatus>(entity =>
            {
                entity.ToTable("RUMCCallsStatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaleStatusType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusShortName)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .HasColumnName("ClientID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatorId).HasColumnName("CreatorID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.FrontRunnerUserId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.JobTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NextFollowUp).IsUnicode(false);

                entity.Property(e => e.OpportunityType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Person)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PersonFirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PersonLastName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedRevenue)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PotentialName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Referral)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RelationshipManagerId).HasColumnName("RelationshipManagerID");

                entity.Property(e => e.SalesCampaignId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesCampaignOwnerUserId).HasDefaultValueSql("((0))");

                entity.Property(e => e.SalesEngineerUserId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SalesManagerUserId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.SalesProductId).HasColumnName("SalesProductID");

                entity.Property(e => e.SalesTeam)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryPhone)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesActions>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.ActionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ActionPersonId).HasColumnName("ActionPersonID");

                entity.Property(e => e.FollowUpNotes).IsUnicode(false);

                entity.Property(e => e.NextActionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalesActionsInSale>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SaleId).HasColumnName("SaleID");

                entity.Property(e => e.SalesActionId).HasColumnName("SalesActionID");
            });

            modelBuilder.Entity<SalesCampaign>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.Deadline).HasColumnType("date");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.PreRequisites).IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesCampaignActivity>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesCampaignId).HasColumnName("SalesCampaignID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SalesDailyPlan>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateFinished)
                    .HasColumnName("date_finished")
                    .HasColumnType("date");

                entity.Property(e => e.Notes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ProjectActionId).HasColumnName("project_action_id");

                entity.Property(e => e.SaleId).HasColumnName("sale_id");

                entity.Property(e => e.Sort)
                    .HasColumnName("sort")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SubprojectId).HasColumnName("subproject_id");
            });

            modelBuilder.Entity<SalesDailyPlanLock>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<SalesDailyPlanNotes>(entity =>
            {
                entity.Property(e => e.CreatedDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note).IsRequired();
            });

            modelBuilder.Entity<SalesManagers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");
            });

            modelBuilder.Entity<SalesPartner>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(800)
                    .IsUnicode(false);

                entity.Property(e => e.Contacts).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastContactDate).HasColumnType("datetime");

                entity.Property(e => e.LastContactUserId).HasColumnName("LastContactUserID");

                entity.Property(e => e.Leads).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RespUserId).HasColumnName("RespUserID");
            });

            modelBuilder.Entity<SalesPartnerLeadContact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsContact).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLead).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPartnerId).HasColumnName("SalesPartnerID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<SalesProducts>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScheduledClientReport>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.LastGeneratedDate).HasColumnType("datetime");

                entity.Property(e => e.PeriodFrom).HasColumnType("datetime");

                entity.Property(e => e.PeriodTo).HasColumnType("datetime");

                entity.Property(e => e.Recipients).IsRequired();

                entity.Property(e => e.RepeatPattern).IsRequired();

                entity.Property(e => e.RequesterName).IsRequired();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ClientNavigation)
                    .WithMany(p => p.ScheduledClientReport)
                    .HasForeignKey(d => d.Client)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportClient");
            });

            modelBuilder.Entity<SearchTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SearchTMP");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasIndex(e => e.ParentId)
                    .HasName("IX_Service");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<ServicesPeriods>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Days)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1234567')");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.ProcessToDeviceId).HasColumnName("ProcessToDeviceID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ShiftCalendar>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Shift1).HasColumnName("Shift_1");

                entity.Property(e => e.Shift2).HasColumnName("Shift_2");
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AmountOfPackages).HasDefaultValueSql("((1))");

                entity.Property(e => e.AssignedPerson)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DeclaredValue)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PackageSize)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PickupDate).HasColumnType("datetime");

                entity.Property(e => e.PotentialName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.RelatedProjectIdAddressedTo).HasColumnName("RelatedProjectID_AddressedTo");

                entity.Property(e => e.RelatedProjectIdSender).HasColumnName("RelatedProjectID_Sender");

                entity.Property(e => e.SendByDate).HasColumnType("datetime");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.Shipment1)
                    .HasColumnName("Shipment#")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TicketIdAddressedTo).HasColumnName("TicketID_AddressedTo");

                entity.Property(e => e.TicketIdSender).HasColumnName("TicketID_Sender");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Weight)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShipmentPackageType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PackageType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShipmentServiceType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ServiceType)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Smtpsensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("SMTPSensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_SMTPSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConnectionTimeOut).HasDefaultValueSql("((30))");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.Port).HasDefaultValueSql("((1433))");

                entity.Property(e => e.Smtpaddress)
                    .IsRequired()
                    .HasColumnName("SMTPAddress")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Snmppuller>(entity =>
            {
                entity.ToTable("SNMPPuller");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PassKey)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sqlsensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SQLSensor__0371755F")
                    .IsClustered(false);

                entity.ToTable("SQLSensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_SQLSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConnectionTimeOut).HasDefaultValueSql("((30))");

                entity.Property(e => e.Dbname)
                    .IsRequired()
                    .HasColumnName("DBName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.Port).HasDefaultValueSql("((1433))");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasColumnName("PWD")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlserver)
                    .IsRequired()
                    .HasColumnName("SQLServer")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sqlstatement)
                    .IsRequired()
                    .HasColumnName("SQLStatement")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subnet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndIp).HasColumnName("endIP");

                entity.Property(e => e.StartIp).HasColumnName("startIP");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SumiSupportRotation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.PrimaryName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<SumitomoDrives>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Drive)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastDt).HasColumnType("datetime");

                entity.Property(e => e.Ts)
                    .HasColumnName("TS")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SumitomoSwift>(entity =>
            {
                entity.ToTable("Sumitomo_SWIFT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");

                entity.Property(e => e.VerificationCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemAudit>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SystemEvent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SystemEventToDevice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.SystemEventId).HasColumnName("SystemEventID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClosingNotes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeadLine).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.UpdateClosingNotes).HasColumnName("updateClosingNotes");

                entity.Property(e => e.UpdateHoursSpent).HasColumnName("updateHoursSpent");
            });

            modelBuilder.Entity<TaskStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TaskType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Tcpsensor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__TCPSensor__1F04813B")
                    .IsClustered(false);

                entity.ToTable("TCPSensor");

                entity.HasIndex(e => e.DeviceId)
                    .HasName("IDX_TCPSensor_DeviceID")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExpectedResponse)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.HostId).HasColumnName("HostID");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastPullEnd).HasColumnType("datetime");

                entity.Property(e => e.LastPullStart).HasColumnType("datetime");

                entity.Property(e => e.Port).HasDefaultValueSql("((23))");

                entity.Property(e => e.Request)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TcpsensorHost>(entity =>
            {
                entity.ToTable("TCPSensorHost");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassKey)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TelehouseAnswers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerText)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");
            });

            modelBuilder.Entity<TelehouseClients>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesManName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TelehouseContacts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempXml>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempXML");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Xmltext)
                    .HasColumnName("XMLText")
                    .HasColumnType("xml");
            });

            modelBuilder.Entity<Threat>(entity =>
            {
                entity.Property(e => e.ControlLastTested).HasColumnType("date");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentControl)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResidualRiskImpact)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResidualRiskLikelihood)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RiskImpact)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ThreatEvent)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.ControlEffectivenessNavigation)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.ControlEffectiveness)
                    .HasConstraintName("FK_Threat_ControlEffectiveness");

                entity.HasOne(d => d.ControlOwnerNavigation)
                    .WithMany(p => p.ThreatControlOwnerNavigation)
                    .HasForeignKey(d => d.ControlOwner)
                    .HasConstraintName("FK_Threat_ControlOwner");

                entity.HasOne(d => d.ControlTestResultsNavigation)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.ControlTestResults)
                    .HasConstraintName("FK_Threat_ControlTestResults");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ThreatCreatedUser)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Threat_Users");

                entity.HasOne(d => d.OwnerUser)
                    .WithMany(p => p.ThreatOwnerUser)
                    .HasForeignKey(d => d.OwnerUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Threat_Users1");

                entity.HasOne(d => d.RiskLikelihoodNavigation)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.RiskLikelihood)
                    .HasConstraintName("FK_Threat_RiskLikelihood");

                entity.HasOne(d => d.RiskRatingNavigation)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.RiskRating)
                    .HasConstraintName("FK_Threat_RiskRating");

                entity.HasOne(d => d.ThreatActionPlanType)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.ThreatActionPlanTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Threat_ThreatActionPlanType");

                entity.HasOne(d => d.ThreatAssetType)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.ThreatAssetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Threat_ThreatAssetType");

                entity.HasOne(d => d.ThreatContextNavigation)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.ThreatContext)
                    .HasConstraintName("FK_Threat_ThreatContext");

                entity.HasOne(d => d.ThreatResponseType)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.ThreatResponseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Threat_ThreatResponseType");

                entity.HasOne(d => d.ThreatType)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.ThreatTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Threat_ThreatType");

                entity.HasOne(d => d.ThreatVulnerabilityType)
                    .WithMany(p => p.Threat)
                    .HasForeignKey(d => d.ThreatVulnerabilityTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Threat_ThreatVulnerabilityType");
            });

            modelBuilder.Entity<ThreatActionPlanType>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ThreatAssetType>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ThreatChangeLog>(entity =>
            {
                entity.Property(e => e.ColumnTitle)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ThreatChangeLog)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThreatChangeLog_Users");

                entity.HasOne(d => d.Threat)
                    .WithMany(p => p.ThreatChangeLog)
                    .HasForeignKey(d => d.ThreatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThreatChangeLog_Threat");
            });

            modelBuilder.Entity<ThreatContextType>(entity =>
            {
                entity.Property(e => e.Context)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThreatControlEffectivenessType>(entity =>
            {
                entity.Property(e => e.ControlEffectiveness)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThreatControlTestResultType>(entity =>
            {
                entity.Property(e => e.TestResult)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThreatResponseType>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ThreatReview>(entity =>
            {
                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ThreatReview)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThreatReview_Users");
            });

            modelBuilder.Entity<ThreatReviewChangeLog>(entity =>
            {
                entity.Property(e => e.ColumnTitle)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedUser)
                    .WithMany(p => p.ThreatReviewChangeLog)
                    .HasForeignKey(d => d.CreatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThreatReviewChangeLog_Users");

                entity.HasOne(d => d.ThreatReview)
                    .WithMany(p => p.ThreatReviewChangeLog)
                    .HasForeignKey(d => d.ThreatReviewId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThreatReviewChangeLog_ThreatReview");
            });

            modelBuilder.Entity<ThreatRiskImpactType>(entity =>
            {
                entity.Property(e => e.Impact)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThreatRiskLikelihoodType>(entity =>
            {
                entity.Property(e => e.Likelihood)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThreatRiskRatingType>(entity =>
            {
                entity.Property(e => e.RiskRating)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThreatType>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ThreatVulnerabilityType>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasIndex(e => e.ParentTicketId)
                    .HasName("IX_Ticket_ParentTicketId");

                entity.HasIndex(e => e.TicketId)
                    .HasName("UQ__Ticket__2D288360")
                    .IsUnique();

                entity.HasIndex(e => new { e.StatusAdminId, e.StatusId });

                entity.HasIndex(e => new { e.StatusId, e.AssignedTo });

                entity.HasIndex(e => new { e.StatusId, e.ImplementationFlag });

                entity.HasIndex(e => new { e.Id, e.StatusDate, e.StatusId })
                    .HasName("IX_Ticket_StatusID");

                entity.HasIndex(e => new { e.Id, e.Body, e.ClientTicketId, e.Deadline, e.StartDate, e.ClientId })
                    .HasName("IX_Ticket_ClientID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.AssignedBy).HasDefaultValueSql("((4))");

                entity.Property(e => e.Body)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeRequestInfo).IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientTicketId)
                    .HasColumnName("ClientTicketID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasColumnType("datetime");

                entity.Property(e => e.EmailFrom).HasMaxLength(4000);

                entity.Property(e => e.EmailTo).HasMaxLength(4000);

                entity.Property(e => e.ExecutionStatusId).HasDefaultValueSql("((2))");

                entity.Property(e => e.History)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.ParentTicketId).HasColumnName("ParentTicketID");

                entity.Property(e => e.Priority).HasDefaultValueSql("((2))");

                entity.Property(e => e.Resolution)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusAdminId)
                    .HasColumnName("StatusAdminID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject).HasMaxLength(4000);

                entity.Property(e => e.TicketId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.TicketRoid)
                    .HasColumnName("TicketROId")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<TicketApprovalStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketBak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ticket_bak");

                entity.Property(e => e.AdminNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Body)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientTicketId)
                    .HasColumnName("ClientTicketID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasColumnType("datetime");

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.ParentTicketId).HasColumnName("ParentTicketID");

                entity.Property(e => e.Resolution)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusAdminId).HasColumnName("StatusAdminID");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TicketRoid).HasColumnName("TicketROId");

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<TicketChangeSet>(entity =>
            {
                entity.HasIndex(e => e.Ticket);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.TicketNavigation)
                    .WithMany(p => p.TicketChangeSet)
                    .HasForeignKey(d => d.Ticket)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeSetTicket");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.TicketChangeSet)
                    .HasForeignKey(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChangeSetUser");
            });

            modelBuilder.Entity<TicketClass>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TicketExecutionStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketField>(entity =>
            {
                entity.HasIndex(e => e.ChangeSet)
                    .HasName("IX_TicketFieldsChangeSet");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChangeSetNavigation)
                    .WithMany(p => p.TicketField)
                    .HasForeignKey(d => d.ChangeSet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketFieldChangeSet");
            });

            modelBuilder.Entity<TicketFollowers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TicketImplementationFlag>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketPriority>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TicketId });

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.TicketId).HasColumnName("ticketId");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketPriority)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ticketId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TicketPriority)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_userId");
            });

            modelBuilder.Entity<TicketReponseSource>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketResponse>(entity =>
            {
                entity.HasIndex(e => e.ChangeSet)
                    .HasName("IX_TicketResponseChangeSet");

                entity.HasIndex(e => e.TicketId);

                entity.HasIndex(e => new { e.TicketId, e.ClientResponseId })
                    .HasName("IX_TicketResponse_ClientResponseId");

                entity.HasIndex(e => new { e.Id, e.Source, e.Acknowledged, e.TicketId })
                    .HasName("IX_TicketResponse_Source_Acknowledged");

                entity.HasIndex(e => new { e.TicketId, e.Timestamp, e.Source, e.Acknowledged })
                    .HasName("IX_TicketResponse_4Cols");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AcknowledgedOn).HasColumnType("datetime");

                entity.Property(e => e.ClientResponseId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Source).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.TicketResponse)
                    .HasForeignKey(d => d.TicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TicketResponseTicket");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.TicketResponse)
                    .HasForeignKey(d => d.User)
                    .HasConstraintName("FK__TicketResp__User__52C41C63");
            });

            modelBuilder.Entity<TicketResponseAttachmentTest>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Content).HasColumnType("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Response)
                    .WithMany(p => p.TicketResponseAttachmentTest)
                    .HasForeignKey(d => d.ResponseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TicketResponseAttachmentTest_ResponseId");
            });

            modelBuilder.Entity<TicketSatisfactionStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketStatistics>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");
            });

            modelBuilder.Entity<TicketStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketTlacknowledge>(entity =>
            {
                entity.ToTable("TicketTLAcknowledge");

                entity.HasIndex(e => e.AcknowledgedOn)
                    .HasName("IX_TicketTLAcknowledge_3");

                entity.HasIndex(e => e.TicketChangesetId)
                    .HasName("IX_TicketTLAcknowledge_1");

                entity.HasIndex(e => e.TicketId)
                    .HasName("IX_TicketTLAcknowledge");

                entity.HasIndex(e => e.TicketResponseId)
                    .HasName("IX_TicketTLAcknowledge_2");

                entity.HasIndex(e => new { e.TicketChangesetId, e.HiddenTicket })
                    .HasName("IX_TicketTLAcknowledge_4");

                entity.Property(e => e.AcknowledgedOn).HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TicketType>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.Id)
                    .HasName("UQ__TicketType__55EAA1D1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TicketUserFollowers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TimeOfService>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TimeOfServiceDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TimeTracking>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MedicalHoursId).HasColumnName("MedicalHoursID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid).HasColumnName("UID");

                entity.Property(e => e.VocationHoursId).HasColumnName("VocationHoursID");
            });

            modelBuilder.Entity<TmpUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tmp_Users");

                entity.Property(e => e.BPwd)
                    .HasColumnName("bPWD")
                    .HasMaxLength(100);

                entity.Property(e => e.DomainName).HasMaxLength(64);

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IsAccountManager).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNotGettingKwalerts).HasColumnName("IsNotGettingKWAlerts");

                entity.Property(e => e.IsOverseer).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTechnicalLead).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrapMessage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DatetimeCreated)
                    .HasColumnName("datetime_created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Oid)
                    .HasColumnName("oid")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SenderIp)
                    .IsRequired()
                    .HasColumnName("sender_ip")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrapMessageVariable>(entity =>
            {
                entity.HasIndex(e => e.MessageId);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Key)
                    .HasColumnName("key")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId).HasColumnName("message_id");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrapOids>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("TrapOIDs");

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserCertification>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.UserCertification)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_UserCertification_CertificationStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCertification)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserCertification_Users");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.UserCertification)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCertification_CertificationVendor");
            });

            modelBuilder.Entity<UserSettings>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Development).HasDefaultValueSql("((1))");

                entity.Property(e => e.HardwareFailure)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.HelpDesk).HasDefaultValueSql("((0))");

                entity.Property(e => e.Implementation).HasDefaultValueSql("((1))");

                entity.Property(e => e.MeOnly)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Operation).HasDefaultValueSql("((1))");

                entity.Property(e => e.SkipClientIds)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TicketsClientId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.View)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WithTicketsOnly)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BPwd)
                    .HasColumnName("bPWD")
                    .HasMaxLength(100);

                entity.Property(e => e.DomainName).HasMaxLength(64);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.IsNotGettingKwalerts)
                    .HasColumnName("IsNotGettingKWAlerts")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReportsAccessDev).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportsAccessOps).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportsAccessProj).HasDefaultValueSql("((0))");

                entity.Property(e => e.SentEmail).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid)
                    .IsRequired()
                    .HasColumnName("UID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Vpnkeyword)
                    .HasColumnName("VPNKeyword")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vpnphone)
                    .HasColumnName("VPNPhone")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usfacilities>(entity =>
            {
                entity.ToTable("USFacilities");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VClientsExceptRumc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vClientsExceptRumc");

                entity.Property(e => e.AlertNotificationsRecipients)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BackupRecoveryInfo).HasColumnType("text");

                entity.Property(e => e.ClientKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CmonEscalationProcedure)
                    .HasColumnName("CMonEscalationProcedure")
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceAuditCity).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditClientName).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditEmail).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditFax).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditPhone).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditState).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditStreet).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditWebsite).HasMaxLength(500);

                entity.Property(e => e.DeviceAuditZip)
                    .HasColumnName("DeviceAuditZIP")
                    .HasMaxLength(500);

                entity.Property(e => e.EscalationProcedure).IsUnicode(false);

                entity.Property(e => e.EscalationProcedureUpdated)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EscallationProcedure).IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Itservices)
                    .HasColumnName("ITServices")
                    .HasColumnType("text");

                entity.Property(e => e.MaintModeStart).HasColumnType("datetime");

                entity.Property(e => e.PasswordInfo).HasColumnType("text");

                entity.Property(e => e.RelationshipManagerId).HasColumnName("RelationshipManagerID");

                entity.Property(e => e.ReportPrefix)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ScopeOfService).HasColumnType("text");

                entity.Property(e => e.Sla).HasColumnName("SLA");

                entity.Property(e => e.SoftwareInfo).HasColumnType("text");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VLastSessionLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLastSessionLog");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.HeartBeatId).HasColumnName("HeartBeatID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SessionLogStatusId).HasColumnName("SessionLogStatusID");

                entity.Property(e => e.SessionType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VReportTiketsTimeTaken>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vReportTiketsTimeTaken");

                entity.Property(e => e.Body)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mins).HasColumnName("mins");

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.OwnerDateTime).HasColumnType("datetime");

                entity.Property(e => e.OwnerTime)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VSatisfactionReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSatisfactionReport");

                entity.Property(e => e.Month).HasMaxLength(30);

                entity.Property(e => e.Reopened)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SatisfactionStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VTicketsExceptRumc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTicketsExceptRumc");

                entity.Property(e => e.AdminNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Body)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ClientTicketId)
                    .HasColumnName("ClientTicketID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CloseDate).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasColumnType("datetime");

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.ParentTicketId).HasColumnName("ParentTicketID");

                entity.Property(e => e.Resolution)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusAdminId).HasColumnName("StatusAdminID");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Tid)
                    .HasColumnName("TID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<VTicketsSummaryStatuses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTicketsSummaryStatuses");

                entity.Property(e => e.OpenDate).HasColumnType("date");

                entity.Property(e => e.Tickets1).HasColumnName("Tickets_1");

                entity.Property(e => e.Tickets2).HasColumnName("Tickets_2");

                entity.Property(e => e.Tickets3).HasColumnName("Tickets_3");

                entity.Property(e => e.Tickets4).HasColumnName("Tickets_4");

                entity.Property(e => e.Tickets8).HasColumnName("Tickets_8");

                entity.Property(e => e.Tickets9).HasColumnName("Tickets_9");

                entity.Property(e => e.TicketsExcelent).HasColumnName("Tickets_Excelent");

                entity.Property(e => e.TicketsNotSatisfied).HasColumnName("Tickets_NotSatisfied");

                entity.Property(e => e.TicketsReopened).HasColumnName("Tickets_Reopened");

                entity.Property(e => e.TicketsSatisfied).HasColumnName("Tickets_Satisfied");
            });

            modelBuilder.Entity<VacationHolidays>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<VendorDocuments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MapFile)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Version1).HasColumnName("Version");
            });

            modelBuilder.Entity<VocationHours>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TotalAlloted).HasDefaultValueSql("((80))");

                entity.Property(e => e.TotalLeft).HasComputedColumnSql("(((((((((((([TotalAlloted]-[Jan])-[feb])-[Mar])-[Apr])-[May])-[Jun])-[Jul])-[Aug])-[Sep])-[Oct])-[Nov])-[Dec])");

                entity.Property(e => e.TotalUsed).HasComputedColumnSql("((((((((((([Jan]+[Feb])+[Mar])+[Apr])+[May])+[Jun])+[Jul])+[Aug])+[Sep])+[Oct])+[Nov])+[Dec])");

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<VocationRequest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(2048)
                    .IsUnicode(false);

                entity.Property(e => e.Ts)
                    .HasColumnName("ts")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Uid).HasColumnName("UID");
            });

            modelBuilder.Entity<Vpnmanager>(entity =>
            {
                entity.ToTable("VPNManager");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastReported).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PassKey)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VpnsessionVerificationStatus>(entity =>
            {
                entity.ToTable("VPNSessionVerificationStatus");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vpnsessions>(entity =>
            {
                entity.HasKey(e => new { e.DeviceId, e.SessionIndex, e.LoginTime });

                entity.ToTable("VPNSessions");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.BytesRx).HasColumnName("BytesRX");

                entity.Property(e => e.BytesTx).HasColumnName("BytesTX");

                entity.Property(e => e.FirstReportedTs)
                    .HasColumnName("FirstReportedTS")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastReportedTs)
                    .HasColumnName("LastReportedTS")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VerificationReceivedTs)
                    .HasColumnName("VerificationReceivedTS")
                    .HasColumnType("datetime");

                entity.Property(e => e.VerificationSentTs)
                    .HasColumnName("VerificationSentTS")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Vritapes>(entity =>
            {
                entity.HasKey(e => new { e.MediaId, e.Client });

                entity.ToTable("VRITapes");

                entity.Property(e => e.MediaId)
                    .HasColumnName("MediaID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DataSetName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.TapeStatus).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<VritapesBack>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VRITapesBack");

                entity.Property(e => e.Client)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DataSetName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MediaId)
                    .IsRequired()
                    .HasColumnName("MediaID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VritapesBack20140109>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VRITapesBack_20140109");

                entity.Property(e => e.Client)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DataSetName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MediaId)
                    .IsRequired()
                    .HasColumnName("MediaID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VritapesHistory>(entity =>
            {
                entity.HasKey(e => new { e.Year, e.Month, e.MediaId, e.Client });

                entity.ToTable("VRITapesHistory");

                entity.Property(e => e.MediaId)
                    .HasColumnName("MediaID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DataSetName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.TapeStatus).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<VwAspnetApplications>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<WikiRev>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DateModified)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RevId).HasColumnName("RevID");

                entity.Property(e => e.StatusUpdateMessage).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
