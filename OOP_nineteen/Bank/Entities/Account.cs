using System;

namespace Exercise
{

    //abstract make the class unable to start instance
    abstract class Acc
    {
        string test { get; set; }
        public Acc(string us)
        {
            test = us;
        }
    }
}