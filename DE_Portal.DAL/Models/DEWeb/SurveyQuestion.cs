using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class SurveyQuestion
    {
        public SurveyQuestion()
        {
            SurveyQuestionAnswer = new HashSet<SurveyQuestionAnswer>();
            SurveyQuestionManager = new HashSet<SurveyQuestionManager>();
            SurveySubmissionAnswer = new HashSet<SurveySubmissionAnswer>();
        }

        public int SurveyQuestionId { get; set; }
        public int SurveyQuestionTypeId { get; set; }
        public string SurveyQuestionText { get; set; }
        public string SurveryQuestionlText2 { get; set; }

        public virtual SurveyQuestionType SurveyQuestionType { get; set; }
        public virtual ICollection<SurveyQuestionAnswer> SurveyQuestionAnswer { get; set; }
        public virtual ICollection<SurveyQuestionManager> SurveyQuestionManager { get; set; }
        public virtual ICollection<SurveySubmissionAnswer> SurveySubmissionAnswer { get; set; }
    }
}
