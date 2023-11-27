using System;
namespace Shop
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }
        // public ImportedProduct(){}
        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }
        public override string priceTag()
        {
            return $"{TotalPrice()} (Customs fee: $ {this.CustomFee})";
        }

        public double TotalPrice()
        {
            return base.Price + CustomFee;
        }
    }

}