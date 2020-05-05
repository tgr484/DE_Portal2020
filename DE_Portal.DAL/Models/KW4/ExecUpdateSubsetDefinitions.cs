using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ExecUpdateSubsetDefinitions
    {
        public int Id { get; set; }
        public DateTime Ts { get; set; }
        public string SubsetName { get; set; }
        public int SetRef { get; set; }
        public string ParamRef { get; set; }
        public string Type { get; set; }
        public int? SortOrder { get; set; }

        public virtual ExecUpdateSetDefinitions SetRefNavigation { get; set; }
    }
}
