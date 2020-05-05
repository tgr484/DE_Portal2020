using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TrapMessageVariable
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
