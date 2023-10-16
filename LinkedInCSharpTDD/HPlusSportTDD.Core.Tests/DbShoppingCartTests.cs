using Moq;
using Moq.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPlusSportTDD.Core
{
    class DbShoppingCartTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ShouldReturnArticlesInCart()
        {
            var initialItems = new AddToCartItem[]
            {
                new AddToCartItem(id: 1, articleId: 42, quantity: 5)
            };

            var mockContext = new Mock<ShoppingCartContext>();
            mockContext.Setup(ctx => ctx.Items).ReturnsDbSet(initialItems);

            var manager = new DbShoppingCartManager(mockContext.Object);
            
            var items = manager.GetCart();

            Assert.That(items, Is.EqualTo(initialItems));
        }
    }
}
