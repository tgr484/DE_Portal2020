using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class BpmnotificationOverrides
    {
        public int Id { get; set; }
        public int InstanceId { get; set; }
        public DateTime NotificationDate { get; set; }
        public string Note { get; set; }
    }
}
