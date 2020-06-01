using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.Models
{
    public class ScheduledEventModel
    {
        public string title { get; set; }
        public DateTime start { get; set; }
        public DateTime? end { get; set; }

        public string url { get; set; }

        public string className { get; set; }
    }
}
