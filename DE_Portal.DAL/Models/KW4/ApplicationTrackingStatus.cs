using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ApplicationTrackingStatus
    {
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public string Status { get; set; }
        public string AssignedColor { get; set; }
    }
}
