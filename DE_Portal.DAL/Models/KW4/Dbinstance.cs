using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Dbinstance
    {
        public Dbinstance()
        {
            InvComponentDbinstance = new HashSet<InvComponentDbinstance>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string InstanceName { get; set; }
        public int InstanceTypeId { get; set; }
        public int? DeviceId { get; set; }

        public virtual Device Device { get; set; }
        public virtual DbinstanceType InstanceType { get; set; }
        public virtual ICollection<InvComponentDbinstance> InvComponentDbinstance { get; set; }
    }
}
