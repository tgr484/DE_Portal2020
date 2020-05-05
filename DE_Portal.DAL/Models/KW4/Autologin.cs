using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Autologin
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public decimal Code { get; set; }
        public DateTime Ts { get; set; }
    }
}
