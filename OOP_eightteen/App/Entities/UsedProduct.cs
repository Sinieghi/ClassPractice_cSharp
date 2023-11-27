using System;
namespace Shop
{
    class UserProduct : Product
    {

        public DateTime ManufatureDate { get; set; }

        public UserProduct(string name, double price, DateTime manufatureDate) :
        base(name, price)
        {
            ManufatureDate = manufatureDate;
        }
        public override string priceTag()
        {
            return $"(used) $ {this.Price} (Manufature date: {this.ManufatureDate})";
        }
    }

}