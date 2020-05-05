using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientUsers
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string UserName { get; set; }
        public string CellPhone { get; set; }
    }
}
