using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientTicketNotifications
    {
        public int Id { get; set; }
        public int RecipientId { get; set; }
        public int ClientId { get; set; }
    }
}
