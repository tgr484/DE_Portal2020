using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.Models
{    
    public class ApplicationUser : IdentityUser
    {
        public string Login { get; set; }

        public int ClientId { get; set; }
    }
}
