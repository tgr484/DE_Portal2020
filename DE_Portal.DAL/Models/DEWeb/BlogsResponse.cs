using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class BlogsResponse
    {
        public int Id { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ResponseText { get; set; }
        public Guid? Guid { get; set; }
        public byte? Active { get; set; }
    }
}
