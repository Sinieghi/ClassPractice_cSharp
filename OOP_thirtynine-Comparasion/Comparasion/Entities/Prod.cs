using System;
using System.Globalization;

namespace Practice
{
    //Originally this class was extending IComparable but then we found
    //a problema, because every time you want to change the Sort method you have
    //to change the method CompareTo to accept new type of value
    class Prod(string v1, double v2)
    {
        public string v1 = v1;
        public double v2 = v2;

        public override string ToString()
        {
            return v1 + ", " + v2.ToString("F1", CultureInfo.InvariantCulture);
        }
        public int CompareTo(Prod other)
        {
            return v1.ToUpper().CompareTo(other.v1.ToUpper());
        }
    }
}