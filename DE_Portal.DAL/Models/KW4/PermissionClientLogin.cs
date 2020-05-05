using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class PermissionClientLogin
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int PermissionId { get; set; }
        public int ClientLoginId { get; set; }
        public bool WithGrant { get; set; }

        public virtual Client Client { get; set; }
        public virtual ClientLogin ClientLogin { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
