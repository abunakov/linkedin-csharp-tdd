namespace HPlusSportTDD.Core
{
    public class AddToCartRequest
    {
        public AddToCartRequest(AddToCartItem item)
        {
            Item = item;
        }
        public AddToCartItem Item { get; set; }
    }
}
