using HPlusSportTDD.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSportTDD.Web.Controllers
{
    public class ShopController : Controller
    {
        private List<Article> _articles = new List<Article>() {
            new Article(id: 1, name: "Red T-Shirt", price: 9.99),
            new Article(id: 2, name: "Blue T-Shirt", price: 11.99),
            new Article(id: 3, name: "Green Windbreaker", price: 99.99)
        };

        public IActionResult Index(string query)
        {
            var model = _articles;
            if (!string.IsNullOrWhiteSpace(query))
            {
                model = _articles.Where(a => a.Name.ToLower().Contains(query.ToLower())).ToList();
            }

            return View(model);
        }

    }
}
