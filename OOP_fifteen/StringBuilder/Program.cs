using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Comments c1 = new("Have a nice trip");
            Comments c2 = new("That's awesome");
            Posts p1 = new(
            DateTime.Parse("21/11/2023 18:05:44"),
            "Traveling to new Zeeland",
            "I'm going to visit this country",
            16);
            p1.AddComment(c1);
            p1.AddComment(c2);
            Comments c3 = new("Have a nice trip");
            Comments c4 = new("That's awesome");
            Posts p2 = new(
            DateTime.Parse("21/11/2023 18:05:44"),
            "Traveling to Germany",
            "I'm going to visit this country",
            20);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }
    }
}