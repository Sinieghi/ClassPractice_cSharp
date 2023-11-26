using System;
namespace Enterprise
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsourceEmployee()
        {
        }
        public OutsourceEmployee(string name, string outsourced, int hours, double valuePerHour, double addiTionalCharge) :
         base(name, outsourced, hours, valuePerHour)
        {
            AdditionalCharge = addiTionalCharge;
        }

        public override double CalcWage()
        {
            Console.WriteLine(base.CalcWage() + AdditionalCharge * 1.1);
            return base.CalcWage() + AdditionalCharge * 1.1;
        }

    }
}