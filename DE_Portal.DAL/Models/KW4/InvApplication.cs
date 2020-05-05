using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InvApplication
    {
        public InvApplication()
        {
            InvComponent = new HashSet<InvComponent>();
        }

        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<InvComponent> InvComponent { get; set; }
    }
}
