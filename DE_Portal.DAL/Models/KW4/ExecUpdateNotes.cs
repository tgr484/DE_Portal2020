using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ExecUpdateNotes
    {
        public int Id { get; set; }
        public string ParamRefName { get; set; }
        public int TableId { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
    }
}
