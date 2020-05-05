using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientVendors
    {
        public ClientVendors()
        {
            ClientHardware = new HashSet<ClientHardware>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public string VendorName { get; set; }
        public string ServicesProvided { get; set; }
        public string SalesAssociateName { get; set; }
        public string SalesPhone { get; set; }
        public string Location { get; set; }
        public string Account { get; set; }
        public string VendorEscalationProcedure { get; set; }
        public string OtherInformation { get; set; }
        public byte[] MapFile { get; set; }
        public string UserNotes { get; set; }
        public DateTime Ts { get; set; }

        public virtual ICollection<ClientHardware> ClientHardware { get; set; }
    }
}
