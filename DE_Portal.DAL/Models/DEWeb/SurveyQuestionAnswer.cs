using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class SurveyQuestionAnswer
    {
        public int? SurveyQuestionId { get; set; }
        public string SurveyQuestionAnswerText { get; set; }
        public int? SurveyQuestionAnswerOrder { get; set; }
        public int SurveyQuestionAnswerId { get; set; }

        public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
