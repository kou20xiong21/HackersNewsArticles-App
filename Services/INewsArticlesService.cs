using HackersNewsArticles_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackersNewsArticles_App.Services
{
    public interface INewsArticlesService
    {
        Task<List<NewsArticle>> GetNewsArticles();
    }
}
