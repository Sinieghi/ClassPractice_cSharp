using System;

namespace Practice

{
    class LegalPerson : Irs
    {
        public int NumOfEmployees { get; set; }

        public LegalPerson(double inc, string name, int numOfEmployees) : base(inc, name)
        {
            NumOfEmployees = numOfEmployees;
        }
        public override double CalcTax()
        {
            if (NumOfEmployees > 10)
            {
                return Income - Income * 0.14;
            }
            else
            {
                return Income - Income * 0.16;
            };
        }
    }
}