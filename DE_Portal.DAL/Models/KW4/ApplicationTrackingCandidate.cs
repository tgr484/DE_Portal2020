using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ApplicationTrackingCandidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
        public int Status { get; set; }
        public string Salary { get; set; }
        public string Benefits { get; set; }
        public DateTime? StartDate { get; set; }
        public int VacancyId { get; set; }
        public string NotesStep1 { get; set; }
        public string NotesStep2 { get; set; }
        public string NotesStep3 { get; set; }
        public string NotesStep4 { get; set; }
        public string SalaryAccepted { get; set; }
        public string BenefitsAccepted { get; set; }
        public DateTime? StartDateAccepted { get; set; }
        public DateTime Ts { get; set; }
        public string SalaryRequirement { get; set; }
        public bool Issave { get; set; }
        public string AdditionInfo { get; set; }
        public DateTime? Status1Date { get; set; }
        public DateTime? Status2Date { get; set; }
        public DateTime? Status3Date { get; set; }
        public DateTime? Status4Date { get; set; }
        public DateTime? Status5Date { get; set; }
        public DateTime? Status6Date { get; set; }
        public DateTime? Status7Date { get; set; }
        public DateTime? Status8Date { get; set; }
        public string NotesStep5 { get; set; }
    }
}
