using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DutyRotation
    {
        public DutyRotation()
        {
            DutyRotationFinalize = new HashSet<DutyRotationFinalize>();
            DutyRotationNote = new HashSet<DutyRotationNote>();
        }

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public int CreatedUserId { get; set; }
        public byte? IsTl { get; set; }

        public virtual Users CreatedUser { get; set; }
        public virtual ICollection<DutyRotationFinalize> DutyRotationFinalize { get; set; }
        public virtual ICollection<DutyRotationNote> DutyRotationNote { get; set; }
    }
}
