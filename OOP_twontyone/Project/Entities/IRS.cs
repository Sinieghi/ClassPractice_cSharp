using System;

namespace Practice

{
    abstract class Irs
    {
        public double Income { get; set; }
        public string Name { get; set; }

        public Irs(double inc, string name)
        {
            Income = inc;
            Name = name;
        }
        public abstract double CalcTax();
    }
}