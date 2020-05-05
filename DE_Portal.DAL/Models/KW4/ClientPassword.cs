using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientPassword
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Access { get; set; }
        public string Uid { get; set; }
        public string Pwd { get; set; }
        public int AccessTypeId { get; set; }
        public string Comments { get; set; }
    }
}
