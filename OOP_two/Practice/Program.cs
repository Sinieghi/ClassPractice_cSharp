using System;
using System.Globalization;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Product prod = new Product("TV", 605, 5);

            double p = prod.Price;
            int q = prod.Quantity;


            if (p < 600)
            {
                Console.WriteLine("Preço inválido...");
            }
            else
            {
                prod.Name = "TV 4K";
                string n = prod.Name;
                Console.WriteLine(n);
            };

            // Console.WriteLine("Entre os dados do produto:");
            // Console.WriteLine("Nome: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Preço: ");
            // double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // Console.WriteLine("Quantidade no estoque: ");
            // int quantity = int.Parse(Console.ReadLine());

            // Product p = new Product(name, price, quantity);


            // //com esse constructor não precisa iniciar na outra class, ele pode ser iniciado direto na invocação
            // // Product p2 = new Product { Name = "TV", Price = 555, Quantity = 10 };

            // Console.WriteLine();
            // Console.WriteLine("Dados do produto: " + p);

            // Console.WriteLine();
            // Console.Write(p.TextHandler("adicionar"));
            // int qte = int.Parse(Console.ReadLine());
            // p.AddProducts(qte);

            // System.Console.WriteLine("Dados atualizado: " + p);
            // Console.Write(p.TextHandler("remover"));
            // qte = int.Parse(Console.ReadLine());
            // p.RemoveProducts(qte);
            // System.Console.WriteLine("Dados atualizado: " + p);
        }
    }

}