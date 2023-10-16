using System.ComponentModel;

namespace HPlusSportTDD.Core
{
    public class Article
    {
        public Article(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        [DisplayName("SKU")]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}