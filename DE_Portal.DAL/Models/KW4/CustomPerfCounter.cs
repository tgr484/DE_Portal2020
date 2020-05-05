using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CustomPerfCounter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Object { get; set; }
        public string Counter { get; set; }
        public string CounterType { get; set; }
        public string Instance { get; set; }
        public int DefaultWarnLevel { get; set; }
        public int DefaultCritLevel { get; set; }
        public DateTime Ts { get; set; }
    }
}
