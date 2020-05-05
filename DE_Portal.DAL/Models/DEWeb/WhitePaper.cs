using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.DEWeb
{
    public partial class WhitePaper
    {
        public int WhitePaperId { get; set; }
        public string WhitePaperTitle { get; set; }
        public string WhitePaperShortText { get; set; }
        public DateTime? WhitePaperDate { get; set; }
        public string WhitePaperText { get; set; }
        public bool WhitePaperIsPublished { get; set; }
        public bool WhitePaperIsLink { get; set; }
        public string WhitePaperSurveyName { get; set; }
        public bool WhitePaperIsNews { get; set; }
        public bool WhitePaperIsBlog { get; set; }
    }
}
