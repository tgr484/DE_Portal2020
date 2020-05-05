using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Cabrecords
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserCreated { get; set; }
        public string Participant { get; set; }
        public string Details { get; set; }

        public virtual Users UserCreatedNavigation { get; set; }
    }
}
