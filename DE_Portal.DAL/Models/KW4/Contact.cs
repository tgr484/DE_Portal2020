using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public int? ClientId { get; set; }
        public string City { get; set; }
        public string St { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string MainSwitchboardphone { get; set; }
        public string BusinessPhone { get; set; }
        public string Email { get; set; }
        public bool? Subscribed { get; set; }
        public DateTime? UnsubscribeDate { get; set; }
        public int TypeId { get; set; }
        public string Comment { get; set; }
        public DateTime Ts { get; set; }
    }
}
