using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class SalesActionsInSale
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int SalesActionId { get; set; }
    }
}
