using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DbpropertyHidden
    {
        public string Parameter { get; set; }
        public int HiddenBy { get; set; }
        public DateTime Ts { get; set; }
    }
}
