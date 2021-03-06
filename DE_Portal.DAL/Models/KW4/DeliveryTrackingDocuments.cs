﻿using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class DeliveryTrackingDocuments
    {
        public int Id { get; set; }
        public int DeliveryId { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public byte[] MapFile { get; set; }
        public DateTime Ts { get; set; }
    }
}
