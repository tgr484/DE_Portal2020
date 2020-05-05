using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DutyRotationNote
    {
        public int Id { get; set; }
        public int DutyRotationId { get; set; }
        public int DutyRotationNoteTypeId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ParentDutyRotationNoteId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual DutyRotation DutyRotation { get; set; }
        public virtual DutyRotationNoteType DutyRotationNoteType { get; set; }
    }
}
