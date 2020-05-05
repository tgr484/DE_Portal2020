using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class AlertNotificationStatus
    {
        public int AlertId { get; set; }
        public int Status { get; set; }
        public string StatusSetBy { get; set; }
        public DateTime Ts { get; set; }
    }
}
