using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class MedicalHours
    {
        public int Id { get; set; }
        public short Jan { get; set; }
        public short Feb { get; set; }
        public short Mar { get; set; }
        public short Apr { get; set; }
        public short May { get; set; }
        public short Jun { get; set; }
        public short Jul { get; set; }
        public short Aug { get; set; }
        public short Sep { get; set; }
        public short Oct { get; set; }
        public short Nov { get; set; }
        public short Dec { get; set; }
        public short? TotalUsed { get; set; }
        public short TotalAlloted { get; set; }
        public short? TotalLeft { get; set; }
        public DateTime Ts { get; set; }
    }
}
