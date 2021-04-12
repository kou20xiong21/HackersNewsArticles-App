using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackersNewsArticles_App.Models
{
    public class NewsArticle
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string By { get; set; }
    }
}
