using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class EmailRecipients
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool Enabled { get; set; }
    }
}
