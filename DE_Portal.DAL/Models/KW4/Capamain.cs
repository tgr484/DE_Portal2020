using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class Capamain
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public int Recorded { get; set; }
        public int Client { get; set; }
        public string Observation { get; set; }
        public bool CaorPa { get; set; }
        public string Cpa { get; set; }
        public string Cpat { get; set; }
        public int ImplementedEmployee { get; set; }
        public DateTime SetDeadline { get; set; }
        public DateTime ActualDeadline { get; set; }
        public DateTime? VerificationDate { get; set; }
        public DateTime? SetDeadlineEmailSent { get; set; }
        public DateTime? ActualDeadlineEmailSent { get; set; }
        public int Category { get; set; }
    }
}
