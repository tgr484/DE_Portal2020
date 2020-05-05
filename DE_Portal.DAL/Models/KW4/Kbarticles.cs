using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Kbarticles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? CategoryId { get; set; }
    }
}
