using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientAdministrator
    {
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public int Client { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public string Notes { get; set; }
        public int Permissions { get; set; }

        public virtual Client ClientNavigation { get; set; }
    }
}
