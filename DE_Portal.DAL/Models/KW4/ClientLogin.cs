using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientLogin
    {
        public ClientLogin()
        {
            PermissionClientLogin = new HashSet<PermissionClientLogin>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public string Email { get; set; }
        public DateTime Ts { get; set; }
        public string Name { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<PermissionClientLogin> PermissionClientLogin { get; set; }
    }
}
