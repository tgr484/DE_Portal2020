using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class CmonAccountClients
    {
        public int AccountId { get; set; }
        public string ClientId { get; set; }
        public DateTime Ts { get; set; }
        public string EscalationProcedure { get; set; }
    }
}
