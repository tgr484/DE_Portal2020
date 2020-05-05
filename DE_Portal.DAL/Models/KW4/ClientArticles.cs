using System;
using System.Collections.Generic;

namespace DE_Portal.DAL.Models.KW4
{
    public partial class ClientArticles
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string ClientArticleId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
