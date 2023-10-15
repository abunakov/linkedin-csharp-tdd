using System.Security.Cryptography.X509Certificates;

namespace HPlusSportTDD.Core
{
    public class AddToCartResponse
    {
        public AddToCartResponse(AddToCartItem[] items)
        {
            Items = items;
        }

        public AddToCartItem[] Items { get; set; }
    }
}
