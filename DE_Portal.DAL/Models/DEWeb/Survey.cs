using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class Survey
    {
        public Survey()
        {
            SurveyQuestionManager = new HashSet<SurveyQuestionManager>();
            SurveySubmission = new HashSet<SurveySubmission>();
        }

        public int SurveyId { get; set; }
        public string SurveyName { get; set; }
        public string SurveyTitle { get; set; }
        public string SurveyDescription { get; set; }

        public virtual ICollection<SurveyQuestionManager> SurveyQuestionManager { get; set; }
        public virtual ICollection<SurveySubmission> SurveySubmission { get; set; }
    }
}
