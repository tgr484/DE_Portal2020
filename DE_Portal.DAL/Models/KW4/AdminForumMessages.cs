using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class AdminForumMessages
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public int? UserId { get; set; }
        public DateTime? Ts { get; set; }
        public byte? IsDisplayed { get; set; }
    }
}
