using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class SurveySubmissionAnswer
    {
        public int SurveySubmissionAnswerId { get; set; }
        public int SurveySubmissionId { get; set; }
        public int SurveyQuestionId { get; set; }
        public string SurveySubmissionAnswerValue { get; set; }

        public virtual SurveyQuestion SurveyQuestion { get; set; }
        public virtual SurveySubmission SurveySubmission { get; set; }
    }
}
