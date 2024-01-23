using System;

namespace Practice
{
    //Basically <O> represent any obj type, but is more performance friendly, use <Something> instead object
    class PrintService<F>
    {
        private readonly F[] Value = new F[10];
        private int Count = 0;

        public void AddValue(F value)
        {
            if (Count == 10) throw new InvalidOperationException("Max length");
            Value[Count] = value;
            Count++;
        }

        public F First()
        {
            if (Count == 0) throw new InvalidOperationException("Empty");
            return Value[0];
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < Count - 1; i++)
            {
                System.Console.Write(Value[i] + ", ");
            }
            if (Count > 0)
            {
                System.Console.Write(Value[Count - 1]);
            }
            System.Console.WriteLine("]");
        }

    }
}