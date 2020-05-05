using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InvComponentDevice
    {
        public int Id { get; set; }
        public int ComponentId { get; set; }
        public int DeviceId { get; set; }
        public int DeviceRoleId { get; set; }

        public virtual InvComponent Component { get; set; }
        public virtual Device Device { get; set; }
        public virtual InvDeviceRole DeviceRole { get; set; }
    }
}
