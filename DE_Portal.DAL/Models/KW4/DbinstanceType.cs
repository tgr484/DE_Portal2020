using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DbinstanceType
    {
        public DbinstanceType()
        {
            Dbinstance = new HashSet<Dbinstance>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Dbinstance> Dbinstance { get; set; }
    }
}
