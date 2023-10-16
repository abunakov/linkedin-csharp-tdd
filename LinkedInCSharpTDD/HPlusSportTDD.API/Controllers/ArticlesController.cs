using HPlusSportTDD.Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HPlusSportTDD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private static List<Article> _articles = new List<Article>() {
            new Article(id : 1, name : "Red T-Shirt", price : 9.99),
            new Article(id : 2, name : "Blue T-Shirt", price : 11.99),
            new Article(id : 3, name : "Green Windbreaker", price : 99.99)
        };

        [HttpGet]
        public IEnumerable<Article> GetAll()
        {
            return _articles;
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            var article = _articles.Find(a => a.Id == id);
            
            return article == null ? NotFound(id) : Ok(article);
        }
    }
}
