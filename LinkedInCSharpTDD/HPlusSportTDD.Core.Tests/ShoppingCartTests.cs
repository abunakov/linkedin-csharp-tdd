using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.Core
{
    class ShoppingCartTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ShouldReturnArticleAddedToCart()
        {
            var item = new AddToCartItem(articleId: 42, quantity: 5);

            var request = new AddToCartRequest(item);

            //var manager = new ShoppingCartManager();
            var mockManager = new Mock<IShoppingCartManager>();
            mockManager.Setup(manager => manager
                .AddToCart(It.IsAny<AddToCartRequest>()))
                .Returns(
                    (AddToCartRequest request) => new AddToCartResponse(new AddToCartItem[] { item }
                ));
            AddToCartResponse response = mockManager.Object.AddToCart(request);

            Assert.NotNull(response);
            Assert.IsNotNull(Array.Find(response.Items, x => x.ArticleId == item.ArticleId));
        }

        [Test]
        public void ShouldReturnArticlesAddedToCart()
        {
            var item1 = new AddToCartItem(articleId: 42, quantity: 5);

            var request = new AddToCartRequest(item1);

            var manager = new ShoppingCartManager();
            AddToCartResponse response = manager.AddToCart(request);

            var item2 = new AddToCartItem(articleId: 43, quantity: 10);

            request = new AddToCartRequest(item2);

            response = manager.AddToCart(request);

            Assert.NotNull(response);
            Assert.IsNotNull(Array.Find(response.Items, x => x.ArticleId == item1.ArticleId));
            Assert.IsNotNull(Array.Find(response.Items, x => x.ArticleId == item2.ArticleId));
        }

        [Test]
        public void ShouldReturnCombinedQuantityForTheSameArticle()
        {
            var manager = new ShoppingCartManager();

            var item = new AddToCartItem(articleId: 42, quantity: 5);
            var request = new AddToCartRequest(item);

            AddToCartResponse response = manager.AddToCart(request);

            item = new AddToCartItem(articleId: 42, quantity: 10);
            request = new AddToCartRequest(item);

            response = manager.AddToCart(request);

            Assert.That(Array.Exists(response.Items, x => x.ArticleId == item.ArticleId && x.Quantity == 15));
        }
    }
}
