using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class UserSettings
    {
        public int Id { get; set; }
        public bool CriticalOnly { get; set; }
        public bool? MeOnly { get; set; }
        public bool? WithTicketsOnly { get; set; }
        public bool? Operation { get; set; }
        public bool? Implementation { get; set; }
        public bool? Development { get; set; }
        public bool? HelpDesk { get; set; }
        public bool? Sales { get; set; }
        public string View { get; set; }
        public bool? AccessPrivilege { get; set; }
        public string SkipClientIds { get; set; }
        public string TicketsClientId { get; set; }
        public bool EngineeringOnly { get; set; }
        public bool? HardwareFailure { get; set; }
        public bool FollowedbyMeOnly { get; set; }
    }
}
