using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class BlogsSubscription
    {
        public int Id { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
    }
}
