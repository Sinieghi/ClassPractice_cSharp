using System;
namespace Enterprise
{
    class Employee
    {
        public string Outsourced { get; set; }
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public double Payment { get; set; }
        public Employee() { }
        public Employee(string name, string outsourced, int hours, double valuePerHour)
        {
            Name = name;
            Outsourced = outsourced;
            Hours = hours;
            ValuePerHour = valuePerHour;

        }

        public virtual double CalcWage()
        {
            return Payment = ValuePerHour * Hours;
        }
    }
}