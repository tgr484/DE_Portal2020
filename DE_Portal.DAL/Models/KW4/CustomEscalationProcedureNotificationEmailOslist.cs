using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CustomEscalationProcedureNotificationEmailOslist
    {
        public int Id { get; set; }
        public int EscProcRef { get; set; }
        public int Os { get; set; }

        public virtual CustomEscalationProcedures EscProcRefNavigation { get; set; }
        public virtual Users OsNavigation { get; set; }
    }
}
