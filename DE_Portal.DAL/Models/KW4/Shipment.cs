using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Shipment
    {
        public int Id { get; set; }
        public int? CountryId { get; set; }
        public int ClientId { get; set; }
        public string ContactName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public bool Residental { get; set; }
        public DateTime? ShipDate { get; set; }
        public int NumberOfPackages { get; set; }
        public int AmountOfPackages { get; set; }
        public string Weight { get; set; }
        public string DeclaredValue { get; set; }
        public Guid? DeliveryService { get; set; }
        public int? ServiceType { get; set; }
        public int PackageType { get; set; }
        public string PackageSize { get; set; }
        public DateTime? PickupDate { get; set; }
        public bool IsApproved { get; set; }
        public string AssignedPerson { get; set; }
        public DateTime Ts { get; set; }
        public int? Priority { get; set; }
        public DateTime? SendByDate { get; set; }
        public string Shipment1 { get; set; }
        public int ExistingCompany { get; set; }
        public string PotentialName { get; set; }
        public int ExistingSender { get; set; }
        public int? SenderId { get; set; }
        public string SenderName { get; set; }
        public int? ReceiverId { get; set; }
        public int? RelatedProjectIdAddressedTo { get; set; }
        public int? RelatedProjectIdSender { get; set; }
        public long? TicketIdAddressedTo { get; set; }
        public long? TicketIdSender { get; set; }
    }
}
