using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DutyShifts
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserUid { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}
