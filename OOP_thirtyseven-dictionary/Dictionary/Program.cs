using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = [];

            cookies["user"] = "Luiz";
            cookies["email"] = "L.guilherme@mail.com";
            cookies["phone"] = "95949494949";
            //rewrites above values
            cookies["phone"] = "6545464665";

            System.Console.WriteLine(cookies["user"]);
            cookies.Remove("user");
            if (cookies.ContainsKey("user"))
            {
                System.Console.WriteLine(cookies["user"]);
            }
            else System.Console.WriteLine("No such user.");

            System.Console.WriteLine("Size: " + cookies.Count);

            //Dictionary iterator
            System.Console.WriteLine("all cookies");
            //you can just use var item in cookies instead all this syntax
            foreach (KeyValuePair<string, string> item in cookies)
            {
                System.Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}