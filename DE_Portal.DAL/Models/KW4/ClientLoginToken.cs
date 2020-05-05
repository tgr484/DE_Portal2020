using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientLoginToken
    {
        public int Id { get; set; }
        public int ClientLoginId { get; set; }
        public string Token { get; set; }
    }
}
