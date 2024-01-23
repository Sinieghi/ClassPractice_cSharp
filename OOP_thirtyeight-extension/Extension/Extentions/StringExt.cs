namespace Practice
{
    static class StringExt
    {
        public static string Cut(this String extendStr, int count)
        {
            if (extendStr.Length <= count)
            {
                return extendStr;
            }
            // same as extendStr.Substring(0, count)
            return extendStr[..count] + "...";
        }
    }
}