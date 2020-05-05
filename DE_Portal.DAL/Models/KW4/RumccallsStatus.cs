using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class RumccallsStatus
    {
        public RumccallsStatus()
        {
            Rumccalls = new HashSet<Rumccalls>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<Rumccalls> Rumccalls { get; set; }
    }
}
