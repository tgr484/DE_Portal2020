using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InternalAuditRecordFiles
    {
        public int Id { get; set; }
        public DateTime DateModified { get; set; }
        public int InternalAuditRecordId { get; set; }
        public string FileName { get; set; }
        public byte[] File { get; set; }

        public virtual InternalAuditRecords InternalAuditRecord { get; set; }
    }
}
