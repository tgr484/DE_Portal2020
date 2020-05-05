using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CustomMonitoringFailed
    {
        public int Id { get; set; }
        public string Cmmessage { get; set; }
        public int Cmcounter { get; set; }
        public DateTime Ts { get; set; }
    }
}
