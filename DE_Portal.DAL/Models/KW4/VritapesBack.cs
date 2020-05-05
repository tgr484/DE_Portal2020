using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class VritapesBack
    {
        public string MediaId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string DataSetName { get; set; }
        public int TapeStatus { get; set; }
        public string Client { get; set; }
    }
}
