using System;
namespace Shop
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Price = price;
            Name = name;
        }
        public virtual string priceTag()
        {
            return $" $ {this.Price}";
        }
    }

}