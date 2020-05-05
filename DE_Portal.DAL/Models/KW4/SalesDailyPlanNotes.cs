using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SalesDailyPlanNotes
    {
        public int Id { get; set; }
        public int SalesDailyPlanId { get; set; }
        public string Note { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
    }
}
