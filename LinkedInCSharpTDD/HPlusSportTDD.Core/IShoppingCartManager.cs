namespace HPlusSportTDD.Core
{
    public interface IShoppingCartManager
    {
        AddToCartResponse AddToCart(AddToCartRequest request);
        IEnumerable<AddToCartItem> GetCart();
    }
}
