using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class GlobalSettings
    {
        public int Id { get; set; }
        public string Parameter { get; set; }
        public string Value { get; set; }
        public string Value2 { get; set; }
        public string Ts { get; set; }
    }
}
