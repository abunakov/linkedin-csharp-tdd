using HPlusSportTDD.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.API
{
    public class ArticlesControllerTests
    {
        [Test]
        public void ReturnsExpectedNumberOfArticles()
        {
            var controller = new ArticlesController();

            var articles = controller.GetAll().ToList();

            Assert.That(articles.Count, Is.EqualTo(3));
        }

        [Test]
        public void ReturnsNotFoundWithInvalidId()
        {
            var controller = new ArticlesController();

            var actionResult = controller.GetSingle(4);
            
            Assert.IsInstanceOf<NotFoundObjectResult>(actionResult);
        }
    }
}
