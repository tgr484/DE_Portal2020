using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DiskDestructionLog
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime DestroyedDate { get; set; }
        public int DestroyedByUserId { get; set; }
        public int ClientId { get; set; }
        public string Serial { get; set; }
        public string Notes { get; set; }

        public virtual Client Client { get; set; }
        public virtual Users CreatedUser { get; set; }
        public virtual Users DestroyedByUser { get; set; }
    }
}
