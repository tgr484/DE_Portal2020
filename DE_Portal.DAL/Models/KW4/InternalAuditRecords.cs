using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InternalAuditRecords
    {
        public InternalAuditRecords()
        {
            InternalAuditRecordFiles = new HashSet<InternalAuditRecordFiles>();
        }

        public int Id { get; set; }
        public int InternalAuditId { get; set; }
        public int AuditorId { get; set; }
        public DateTime DateConducted { get; set; }
        public string Comments { get; set; }
        public DateTime Ts { get; set; }

        public virtual ICollection<InternalAuditRecordFiles> InternalAuditRecordFiles { get; set; }
    }
}
