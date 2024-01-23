using System;
namespace Practice
{
    class Prod(string n, double x)
    {
        public string Name { get; set; } = n;
        public double Price { get; set; } = x;

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Prod) return false;
            Prod? other = obj as Prod;

            return Name.Equals(other?.Name) && Price.Equals(other.Price);
        }


    }
}