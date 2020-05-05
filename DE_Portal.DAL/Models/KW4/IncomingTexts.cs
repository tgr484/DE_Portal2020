using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class IncomingTexts
    {
        public int Id { get; set; }
        public string PhoneFrom { get; set; }
        public string PhoneTo { get; set; }
        public string Message { get; set; }
        public DateTime Ts { get; set; }
    }
}
