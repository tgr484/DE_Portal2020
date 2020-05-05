using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class TicketUserFollowers
    {
        public int Id { get; set; }
        public int UserFollowingId { get; set; }
        public int UserFollowerId { get; set; }
    }
}
