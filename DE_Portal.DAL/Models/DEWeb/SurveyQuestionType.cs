using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class SurveyQuestionType
    {
        public SurveyQuestionType()
        {
            SurveyQuestion = new HashSet<SurveyQuestion>();
        }

        public int SurveyQuestionTypeId { get; set; }
        public string SurveyQuestionTypeName { get; set; }

        public virtual ICollection<SurveyQuestion> SurveyQuestion { get; set; }
    }
}
