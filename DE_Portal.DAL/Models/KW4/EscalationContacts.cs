using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EscalationContacts
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phones { get; set; }
        public string Skype { get; set; }
    }
}
