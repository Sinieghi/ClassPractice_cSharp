using System;

namespace Practice

{
    class PhysicalPerson : Irs
    {
        public double HealthValue { get; set; }
        public PhysicalPerson(double inc, string name, double healthValue) : base(inc, name)
        {
            HealthValue = healthValue;
        }
        public override double CalcTax()
        {
            if (Income > 20000)
            {
                return Income - Income * 0.2 - (HealthValue / 2);
            }
            else
            {
                return Income - Income * 0.25 - (HealthValue / 2);
            };
        }
    }
}