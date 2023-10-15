namespace HPlusSportTDD.Core
{
    public class AddToCartItem
    {
        public AddToCartItem(int articleId, int quantity)
        {
            ArticleId = articleId;
            Quantity = quantity;
        }
        public int ArticleId { get; set; }
        public int Quantity { get; set; }
    }
}