using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class IgnoreDiskVolume
    {
        public int Id { get; set; }
        public string VolumeName { get; set; }
        public DateTime? Ts { get; set; }
    }
}
