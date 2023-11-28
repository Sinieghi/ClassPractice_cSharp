using System;

namespace Exercise
{
    class SAccount : Acc
    {
        string Water { get; set; }
        public SAccount(string us, string water) : base(us)
        {
            Water = water;
        }
    }
}