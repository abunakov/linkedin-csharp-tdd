namespace HPlusSportTDD.Core
{
    public class ShoppingCartManager : IShoppingCartManager
    {
        private List<AddToCartItem> _shoppingCart;

        public ShoppingCartManager()
        {
            _shoppingCart = new List<AddToCartItem>();
        }
        public AddToCartResponse AddToCart(AddToCartRequest request)
        {
            var itemAlreadyInCart = _shoppingCart.Find(x => x.ArticleId == request.Item.ArticleId);
            if (itemAlreadyInCart != null)
            {
                itemAlreadyInCart.Quantity += request.Item.Quantity;
            }
            else
            {
                _shoppingCart.Add(request.Item);
            }
            return new AddToCartResponse(_shoppingCart.ToArray());
        }

        public IEnumerable<AddToCartItem> GetCart()
        {
            return _shoppingCart.ToArray();
        }
    }
}
