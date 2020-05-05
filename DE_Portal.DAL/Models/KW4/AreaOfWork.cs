using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class AreaOfWork
    {
        public AreaOfWork()
        {
            Articles = new HashSet<Articles>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? OrderId { get; set; }

        public virtual ICollection<Articles> Articles { get; set; }
    }
}
