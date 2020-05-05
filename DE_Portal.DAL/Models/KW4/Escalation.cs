using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Escalation
    {
        public int Id { get; set; }
        public int? Rank { get; set; }
        public int UserId { get; set; }
    }
}
