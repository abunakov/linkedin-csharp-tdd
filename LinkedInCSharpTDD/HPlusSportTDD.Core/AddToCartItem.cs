namespace HPlusSportTDD.Core
{
    public class AddToCartItem
    {
        public AddToCartItem(int id, int articleId, int quantity)
        {
            ArticleId = articleId;
            Quantity = quantity;
        }
        
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int Quantity { get; set; }
    }
}