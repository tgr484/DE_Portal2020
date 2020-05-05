using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientSoftware
    {
        public int Id { get; set; }
        public byte[] Version { get; set; }
        public int Client { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public string LicenseKey { get; set; }
        public string Description { get; set; }
        public DateTime? SupportDate { get; set; }
        public DateTime? EndOfLifeDate { get; set; }

        public virtual Client ClientNavigation { get; set; }
    }
}
