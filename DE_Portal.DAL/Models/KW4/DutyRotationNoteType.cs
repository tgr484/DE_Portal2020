using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DutyRotationNoteType
    {
        public DutyRotationNoteType()
        {
            DutyRotationNote = new HashSet<DutyRotationNote>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<DutyRotationNote> DutyRotationNote { get; set; }
    }
}
