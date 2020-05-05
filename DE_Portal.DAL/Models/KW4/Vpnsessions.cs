using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Vpnsessions
    {
        public int DeviceId { get; set; }
        public int SessionIndex { get; set; }
        public string Username { get; set; }
        public string Ip { get; set; }
        public DateTime LoginTime { get; set; }
        public long BytesTx { get; set; }
        public long BytesRx { get; set; }
        public DateTime FirstReportedTs { get; set; }
        public DateTime LastReportedTs { get; set; }
        public DateTime? VerificationSentTs { get; set; }
        public DateTime? VerificationReceivedTs { get; set; }
        public int VerificationStatus { get; set; }
        public string Phone { get; set; }
    }
}
