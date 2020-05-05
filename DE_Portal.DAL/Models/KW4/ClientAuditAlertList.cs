using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientAuditAlertList
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientEmployeeName { get; set; }
        public string ClientEmployeeEmail { get; set; }
        public DateTime Ts { get; set; }
    }
}
