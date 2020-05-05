using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ProjectTrackingContractDetails
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public Guid ContractDetailId { get; set; }
        public DateTime Ts { get; set; }
    }
}
