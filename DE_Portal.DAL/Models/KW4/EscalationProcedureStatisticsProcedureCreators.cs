using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EscalationProcedureStatisticsProcedureCreators
    {
        public int Id { get; set; }
        public int Username { get; set; }
        public int NumCorrectlyCreated { get; set; }
        public int NumCorrected { get; set; }
        public int NumRejected { get; set; }

        public virtual Users UsernameNavigation { get; set; }
    }
}
