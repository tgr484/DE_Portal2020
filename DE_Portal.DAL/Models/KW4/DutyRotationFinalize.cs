using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DutyRotationFinalize
    {
        public int Id { get; set; }
        public int DutyRotationId { get; set; }
        public DateTime FinalizedDate { get; set; }
        public DateTime? ConfirmedDate { get; set; }

        public virtual DutyRotation DutyRotation { get; set; }
    }
}
