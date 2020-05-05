using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientVendor
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string SalesName { get; set; }
        public string SalesPhone { get; set; }
        public string Location { get; set; }
        public string AccountNumber { get; set; }
        public int? AttachmentSetId { get; set; }
        public string Services { get; set; }
        public string EscallationProcedure { get; set; }
        public string OtherInfo { get; set; }
        public string UserNotes { get; set; }

        public virtual AttachmentSet AttachmentSet { get; set; }
        public virtual Client Client { get; set; }
    }
}
