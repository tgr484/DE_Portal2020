using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TmpUsers
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string Email { get; set; }
        public int IsAdmin { get; set; }
        public int IsDev { get; set; }
        public int IsMonitorer { get; set; }
        public int IsSale { get; set; }
        public byte[] BPwd { get; set; }
        public int? IsNotGettingKwalerts { get; set; }
        public int SentEmail { get; set; }
        public string DomainName { get; set; }
        public DateTime Ts { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? HireDate { get; set; }
        public int IsShift { get; set; }
        public string Phone { get; set; }
        public int IsAudit { get; set; }
        public int? IsAccountManager { get; set; }
        public int? IsTechnicalLead { get; set; }
        public int? IsOverseer { get; set; }
    }
}
