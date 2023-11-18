using System;
using System.Globalization;
namespace Practice
{
    class Product
    {
        private string _name;
        //essa syntax é usada somente quando n se tem logica no set, caso do name
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        public Product()
        {

        }
        public Product(string name, double price) : this()
        {
            _name = name;
            Price = price;
        }
        public Product(string name, double price, int quantity) : this(name, price)
        {
            Quantity = quantity;
        }


        public Product(string name, int price) : this() { }

        //get setter no C#
        public string Name
        {
            get { return _name; }
            set
            {//value no set do C# é como se fosse um parâmetro
                if (value != null && value.Length > 1)
                    _name = value;
            }
        }

        // public double Price
        // {
        //     get { return _price; }
        // }

        // public int Quantity
        // {
        //     get { return _quantity; }
        //     set { if (value < _quantity) _quantity = value; }
        // }
        public double TotalValueInStock()
        {

            return Price * Quantity;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }
        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }
        public string TextHandler(string operation)
        {
            return $"Digite o número de produtos a ser {operation} do estoque: ";
        }
        //retorna o print de p no program concatenado, isso é um extends?
        public override string ToString()
        {
            return _name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", "
             + Quantity + " unidades, total: $ " +
              TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}