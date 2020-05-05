using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceBackup
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int? Success { get; set; }
        public string JobId { get; set; }
        public string Btype { get; set; }
        public string ExitCode { get; set; }
        public DateTime? Ts { get; set; }
    }
}
