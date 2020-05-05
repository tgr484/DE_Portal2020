using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InvComponentDbinstance
    {
        public int Id { get; set; }
        public int? ComponentId { get; set; }
        public int? DbinstanceId { get; set; }
        public string Databases { get; set; }

        public virtual InvComponent Component { get; set; }
        public virtual Dbinstance Dbinstance { get; set; }
    }
}
