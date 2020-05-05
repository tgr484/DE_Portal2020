using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CustomEscalationProcedureDevices
    {
        public int Id { get; set; }
        public int EscProcRef { get; set; }
        public int Device { get; set; }

        public virtual Device DeviceNavigation { get; set; }
        public virtual CustomEscalationProcedures EscProcRefNavigation { get; set; }
    }
}
