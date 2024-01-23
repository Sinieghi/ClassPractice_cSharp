using System;
using System.Globalization;

namespace Practice
{
    //Interface IComparable thats allow you to use sort on List methods
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmploy)
        {
            string[] Vet = csvEmploy.Split(",");
            Name = Vet[0];
            Salary = double.Parse(Vet[1]);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object? obj)
        {
            if (obj is not Employee)
            {
                throw new ArgumentException("Args is not an employee");
            }
            Employee other = obj as Employee;
            return Name.CompareTo(other.Name);
        }
    }
}