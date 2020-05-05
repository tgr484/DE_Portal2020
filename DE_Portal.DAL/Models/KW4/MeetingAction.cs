using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class MeetingAction
    {
        public int Id { get; set; }
        public int MeetingId { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        public short Status { get; set; }
        public DateTime Ts { get; set; }
    }
}
