using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceEscallationProcedure
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string EscallationProcedure { get; set; }
        public DateTime Ts { get; set; }
    }
}
