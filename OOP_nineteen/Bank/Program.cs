using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //This can't happen in a abstract class, but you can still apply polymorphism
            //  Acc test = new Acc()

            List<Acc> li = [];
            //like here
            li.Add(new BAccount("Using this attempts for test abstract", "Salt"));
            //short overall about abstract class: you basically can't start the instance 
            // but you can still use the abstract class with her child, and they child can
            //use all they methods and inheritance all methods and variables 
        }
    }
}