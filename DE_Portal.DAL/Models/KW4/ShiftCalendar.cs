using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ShiftCalendar
    {
        public int Id { get; set; }
        public int Shift1 { get; set; }
        public int Shift2 { get; set; }
        public int DayOfYear { get; set; }
    }
}
