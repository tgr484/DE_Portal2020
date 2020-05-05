using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TimeOfService
    {
        public int Id { get; set; }
        public int TimeOfServiceStart { get; set; }
        public int TimeOfServiceEnd { get; set; }
        public int DayOfServiceStart { get; set; }
        public int DayOfServiceEnd { get; set; }
        public string TimeOfServiceDescription { get; set; }
        public DateTime Ts { get; set; }
    }
}
