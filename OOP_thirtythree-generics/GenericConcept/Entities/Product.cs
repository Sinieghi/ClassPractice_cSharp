using System.Globalization;

namespace Practice
{
    class Prod(string name, double price) : IComparable
    {
        public string Name { get; set; } = name;

        public double Price { get; set; } = price;

        public int CompareTo(object? obj)
        {
            if (obj is not Prod) throw new ArgumentException("Not a prod");
            Prod other = obj as Prod;
            return Price.CompareTo(other?.Price);
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}