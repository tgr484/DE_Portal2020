using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeletedAlert
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string AlertType { get; set; }
        public string AlertMessage { get; set; }
        public int? AlertValue { get; set; }
        public int AlertCounter { get; set; }
        public DateTime LastUpdateTs { get; set; }
        public int AlertStatus { get; set; }
        public DateTime StatusSetTs { get; set; }
        public int StatusSetAdmin { get; set; }
        public int Criticality { get; set; }
        public DateTime Ts { get; set; }
        public string Comment { get; set; }
        public int SuspendPeriod { get; set; }
        public string History { get; set; }
        public string StatusComment { get; set; }
        public byte AllowDelete { get; set; }
        public int? AlertValue2 { get; set; }
        public bool? NotifyWhenCleared { get; set; }
        public string EscalationProcedure { get; set; }
    }
}
