using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectPriority
    {
        public ProjectPriority()
        {
            EngineeringTaskStatus = new HashSet<EngineeringTaskStatus>();
        }

        public int Id { get; set; }
        public string PriorityName { get; set; }

        public virtual ICollection<EngineeringTaskStatus> EngineeringTaskStatus { get; set; }
    }
}
