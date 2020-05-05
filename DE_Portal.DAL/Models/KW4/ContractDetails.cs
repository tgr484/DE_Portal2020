using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ContractDetails
    {
        public ContractDetails()
        {
            ContractDetailsComment = new HashSet<ContractDetailsComment>();
            ContractDetailsRenewal = new HashSet<ContractDetailsRenewal>();
            ContractDetailsTermsUpdate = new HashSet<ContractDetailsTermsUpdate>();
            ContractPayment = new HashSet<ContractPayment>();
            ContractReminder = new HashSet<ContractReminder>();
            ContractTracking = new HashSet<ContractTracking>();
        }

        public Guid Id { get; set; }
        public byte[] Version { get; set; }
        public Guid Contract { get; set; }
        public int Type { get; set; }
        public int StandardReminders { get; set; }
        public DateTime? CommitmentDate { get; set; }
        public string Terms { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public string Description { get; set; }
        public int? HardwareType { get; set; }
        public Guid? Vendor { get; set; }
        public int? ServiceType { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? StartDate { get; set; }
        public int? ProjectManager { get; set; }
        public bool Notify { get; set; }
        public string Number { get; set; }

        public virtual Contract ContractNavigation { get; set; }
        public virtual Users ProjectManagerNavigation { get; set; }
        public virtual Vendor VendorNavigation { get; set; }
        public virtual ICollection<ContractDetailsComment> ContractDetailsComment { get; set; }
        public virtual ICollection<ContractDetailsRenewal> ContractDetailsRenewal { get; set; }
        public virtual ICollection<ContractDetailsTermsUpdate> ContractDetailsTermsUpdate { get; set; }
        public virtual ICollection<ContractPayment> ContractPayment { get; set; }
        public virtual ICollection<ContractReminder> ContractReminder { get; set; }
        public virtual ICollection<ContractTracking> ContractTracking { get; set; }
    }
}
