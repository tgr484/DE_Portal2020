﻿using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientAzureWebhook
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string WebKey { get; set; }
    }
}
