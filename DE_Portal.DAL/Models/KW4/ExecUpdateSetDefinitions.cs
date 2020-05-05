using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ExecUpdateSetDefinitions
    {
        public ExecUpdateSetDefinitions()
        {
            ExecUpdateSubsetDefinitions = new HashSet<ExecUpdateSubsetDefinitions>();
        }

        public int Id { get; set; }
        public DateTime Ts { get; set; }
        public string SetName { get; set; }
        public string Type { get; set; }
        public int? SortOrder { get; set; }

        public virtual ICollection<ExecUpdateSubsetDefinitions> ExecUpdateSubsetDefinitions { get; set; }
    }
}
