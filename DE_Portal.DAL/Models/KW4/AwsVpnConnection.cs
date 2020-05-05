using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class AwsVpnConnection
    {
        public int Id { get; set; }
        public int? ClientId { get; set; }
        public string Environment { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }
        public DateTime? StatusChangedAt { get; set; }
        public DateTime? LastCheckedOn { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
