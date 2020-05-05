using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class PasswordAccessLog
    {
        public int Id { get; set; }
        public int PasswordId { get; set; }
        public string AccessType { get; set; }
        public string UserId { get; set; }
        public string UserIp { get; set; }
        public DateTime Ts { get; set; }
    }
}
