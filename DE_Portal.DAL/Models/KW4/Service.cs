using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Service
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
    }
}
