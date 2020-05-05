using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientProdSuppAcceptanceMeta
    {
        public int Id { get; set; }
        public byte Enabled { get; set; }
        public int OrderNum { get; set; }
        public string SupportInformation { get; set; }
        public string ProvidedBy { get; set; }
        public string Additional { get; set; }
    }
}
