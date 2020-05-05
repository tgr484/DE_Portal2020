using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Subnet
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public long StartIp { get; set; }
        public long EndIp { get; set; }
        public string Comments { get; set; }
    }
}
