using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeviceConfigHistory
    {
        public int Id { get; set; }
        public int? DeviceConfigInfoId { get; set; }
        public string ConfigData { get; set; }
        public string ConfigCurrentValues { get; set; }
        public string ConfigPreviousValues { get; set; }
        public DateTime? Date { get; set; }
        public int? Approved { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public string ApprovalComments { get; set; }

        public virtual Users ApprovedByNavigation { get; set; }
        public virtual DeviceConfigInfo DeviceConfigInfo { get; set; }
    }
}
