using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Passwords
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? DeviceId { get; set; }
        public string Access { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Comment { get; set; }
        public int? Deleted { get; set; }
        public string SecondaryUserName { get; set; }
        public string SecondaryPassword { get; set; }
    }
}
