namespace Practice
{
    class CalculateService
    {
        // using only a method as a generic
        //to use a > signal you have to say you are only accepting 
        //args that allow that operation where G : IComparable in list case i guess
        public G Max<G>(List<G> list) where G : IComparable
        {
            if (list.Count == 0) throw new ArgumentException("Empty");
            G max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                //remember Compare return -1 if < || 0 if == || and 1 if >
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}