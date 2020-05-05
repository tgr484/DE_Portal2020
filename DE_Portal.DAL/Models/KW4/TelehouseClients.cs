using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TelehouseClients
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string ContactEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyWebsite { get; set; }
        public string SalesManName { get; set; }
    }
}
