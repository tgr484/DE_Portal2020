using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class HrmanagerEmployee
    {
        public int Id { get; set; }
        public int UserIdManager { get; set; }
        public int UserIdEmployee { get; set; }
    }
}
