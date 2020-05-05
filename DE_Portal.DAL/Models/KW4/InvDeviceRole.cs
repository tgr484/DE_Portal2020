using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InvDeviceRole
    {
        public InvDeviceRole()
        {
            InvComponentDevice = new HashSet<InvComponentDevice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InvComponentDevice> InvComponentDevice { get; set; }
    }
}
