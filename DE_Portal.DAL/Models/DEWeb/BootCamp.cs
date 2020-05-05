using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class BootCamp
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public byte Attend { get; set; }
        public string Transport { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Event { get; set; }
    }
}
