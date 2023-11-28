using System;

namespace Exercise
{
    class BAccount : Acc
    {
        string Test { get; set; }
        public BAccount(string us, string test) : base(us)
        {
            Test = test;
        }

        public BAccount(string us) : base(us)
        {
        }
    }
}