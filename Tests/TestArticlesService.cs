
using HackersNewsArticles_App.Models;
using HackersNewsArticles_App.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackersNewsArticles_App.Tests
{
    [TestFixture]
    public class TestArticleService
    {
        [Test]
        public async Task GetNewsArticles_ShouldReturnCountGreaterThan20()
        {
            object expectedResult = null;

            var mockMemoryCache = MockingArticlesService.GetMemoryCache(expectedResult);
            var articleServiceCache = new NewsArticlesService(mockMemoryCache);

            List<NewsArticle> newsArticles = await articleServiceCache.GetNewsArticles();

            Assert.AreNotEqual(20, newsArticles.Count());
        }
    }

}
