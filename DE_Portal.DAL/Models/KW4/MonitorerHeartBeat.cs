using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class MonitorerHeartBeat
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FromHuman { get; set; }
        public DateTime SessionStarted { get; set; }
        public int Delta { get; set; }
        public DateTime Ts { get; set; }
    }
}
