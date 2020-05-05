using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class Rumcbadges
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BadgeId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
