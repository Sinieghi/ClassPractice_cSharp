using System;

namespace Practice

{
    abstract class Irs
    {
        double Income { get; set; }

        public abstract double CalcTax();
    }
}