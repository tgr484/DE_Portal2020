using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ScheduledClientReport
    {
        public Guid Id { get; set; }
        public int Client { get; set; }
        public string RequesterName { get; set; }
        public string Recipients { get; set; }
        public DateTime PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public int Flags { get; set; }
        public int Format { get; set; }
        public string RepeatPattern { get; set; }
        public byte[] Version { get; set; }
        public int GenerationTime { get; set; }
        public DateTime? LastGeneratedDate { get; set; }
        public bool Active { get; set; }

        public virtual Client ClientNavigation { get; set; }
    }
}
