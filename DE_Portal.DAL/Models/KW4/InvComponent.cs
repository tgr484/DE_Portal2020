using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class InvComponent
    {
        public InvComponent()
        {
            InvComponentDbinstance = new HashSet<InvComponentDbinstance>();
            InvComponentDevice = new HashSet<InvComponentDevice>();
        }

        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public string Name { get; set; }
        public string Configuration { get; set; }
        public string Startup { get; set; }
        public string Notes { get; set; }

        public virtual InvApplication Application { get; set; }
        public virtual ICollection<InvComponentDbinstance> InvComponentDbinstance { get; set; }
        public virtual ICollection<InvComponentDevice> InvComponentDevice { get; set; }
    }
}
