using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class SurveySubmission
    {
        public SurveySubmission()
        {
            SurveySubmissionAnswer = new HashSet<SurveySubmissionAnswer>();
        }

        public int SurveySubmissionId { get; set; }
        public int? SurveyId { get; set; }
        public DateTime SurveySubmissionDate { get; set; }
        public string SurveySubmissionClientIp { get; set; }
        public string SurveySubmissionEntryReferer { get; set; }
        public string SurveySubmissionEntryPage { get; set; }
        public string SurveySubmissionReferer { get; set; }
        public string SurveySubmissionPage { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual ICollection<SurveySubmissionAnswer> SurveySubmissionAnswer { get; set; }
    }
}
