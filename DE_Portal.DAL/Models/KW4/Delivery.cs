using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Delivery
    {
        public int Id { get; set; }
        public string Tracking { get; set; }
        public Guid DeliveryServiceId { get; set; }
        public Guid DeliveryStatusId { get; set; }
        public int? SenderId { get; set; }
        public int? SenderCompanyId { get; set; }
        public int AddressedToId { get; set; }
        public int AddressedToCompanyId { get; set; }
        public string PackingSlipNotes { get; set; }
        public string NumberOfPackages { get; set; }
        public string AmountOfPackages { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Guid? ItemLocationId { get; set; }
        public int? RelatedProjectId { get; set; }
        public string Content { get; set; }
        public bool? OpenBox { get; set; }
        public string Prefix { get; set; }
        public int? CreatorId { get; set; }
        public int ExistingCompany { get; set; }
        public string PotentialName { get; set; }
        public DateTime Ts { get; set; }
        public int ExistingSender { get; set; }
        public string SenderName { get; set; }
        public int? ReceiverId { get; set; }
        public string AssignedPerson { get; set; }
        public int? RelatedProjectIdAddressedTo { get; set; }
        public int? RelatedProjectIdSender { get; set; }
        public long? TicketIdAddressedTo { get; set; }
        public long? TicketIdSender { get; set; }
    }
}
