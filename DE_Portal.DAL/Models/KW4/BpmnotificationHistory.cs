using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class BpmnotificationHistory
    {
        public int Id { get; set; }
        public int InstanceId { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public DateTime? Ts { get; set; }
    }
}
