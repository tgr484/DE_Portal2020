using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TimeTracking
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public int VocationHoursId { get; set; }
        public int MedicalHoursId { get; set; }
        public DateTime Ts { get; set; }
    }
}
