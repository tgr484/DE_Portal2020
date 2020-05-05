using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceCactiGraph
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int CactiNum { get; set; }
        public string PathPrefix { get; set; }
        public string CactiName { get; set; }
    }
}
