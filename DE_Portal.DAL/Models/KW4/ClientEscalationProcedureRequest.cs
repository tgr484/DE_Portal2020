using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientEscalationProcedureRequest
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int ClientId { get; set; }
        public int Status { get; set; }
        public int? ClientLoginId { get; set; }
        public string EscalationProcedure { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? UserIdupdated { get; set; }
    }
}
