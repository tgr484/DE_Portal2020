using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Permission
    {
        public Permission()
        {
            PermissionClientLogin = new HashSet<PermissionClientLogin>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Sort { get; set; }

        public virtual ICollection<PermissionClientLogin> PermissionClientLogin { get; set; }
    }
}
