using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackersNewsArticles_App.Models;
using HackersNewsArticles_App.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HackersNewsArticles_App.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private INewsArticlesService _NewsArticlesService;

        public ArticlesController(INewsArticlesService newsArticlesService)
        {
            _NewsArticlesService = newsArticlesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetArticles()
        {
            List<NewsArticle> newsArticleList = new List<NewsArticle>();

            newsArticleList = await _NewsArticlesService.GetNewsArticles();

            if (newsArticleList.Count() == 0)
            {
                return NotFound();
            }

            return Ok(newsArticleList);
        }


        // GET api/<ArticlesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArticlesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArticlesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticlesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
