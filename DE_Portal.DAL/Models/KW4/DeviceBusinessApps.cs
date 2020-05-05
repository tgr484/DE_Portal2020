using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceBusinessApps
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Application { get; set; }
        public string AdditionalInfo { get; set; }
    }
}
