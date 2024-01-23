using System;

namespace Practice
{


    class Program
    {
        static void Main(string[] args)
        {
            List<Prod> ls = [];


            ls.Add(new Prod("TV", 800.00));
            ls.Add(new Prod("Notebook", 1800.00));
            ls.Add(new Prod("Phone", 1000.00));

            //when you call a function without () is called delegate on c#
            //And with this method refed inside this CompareProd you fix the problem
            // described on Prod class, but this happens because Sort method expect a delegate
            //method to be passed.
            // ls.Sort(CompareProd);

            //Rewriting CompareProd in lambda
            // Comparison<Prod> comp = (p1, p2)=> p1.v1.ToUpper().CompareTo(p2.v1.ToUpper());
            //more simplified 
            static int comp(Prod p1, Prod p2) => p1.v1.ToUpper().CompareTo(p2.v1.ToUpper());
            ls.Sort(comp);

            foreach (Prod p in ls)
            {
                System.Console.WriteLine(p);
            }
        }

        // static int CompareProd(Prod p1, Prod p2)
        // {
        //     return p1.v1.ToUpper().CompareTo(p2.v1.ToUpper());
        // }
    }
}