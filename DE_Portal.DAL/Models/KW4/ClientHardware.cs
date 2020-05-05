using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientHardware
    {
        public ClientHardware()
        {
            ClientHardwareDevice = new HashSet<ClientHardwareDevice>();
        }

        public int Id { get; set; }
        public byte[] Version { get; set; }
        public int Client { get; set; }
        public int? ClientVendor { get; set; }
        public string ContractNumber { get; set; }
        public string Description { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? EndOfWarrantyDate { get; set; }

        public virtual Client ClientNavigation { get; set; }
        public virtual ClientVendors ClientVendorNavigation { get; set; }
        public virtual ICollection<ClientHardwareDevice> ClientHardwareDevice { get; set; }
    }
}
