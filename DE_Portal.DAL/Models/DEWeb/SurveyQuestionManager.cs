using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class SurveyQuestionManager
    {
        public int? SurveyQuestionId { get; set; }
        public int? SurveyId { get; set; }
        public int? SurveyQuestionManagerOrder { get; set; }
        public int SurveyQuestionManagerId { get; set; }

        public virtual Survey Survey { get; set; }
        public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
