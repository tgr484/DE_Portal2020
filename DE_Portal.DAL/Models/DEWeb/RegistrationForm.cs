using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class RegistrationForm
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string Campaign { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
    }
}
