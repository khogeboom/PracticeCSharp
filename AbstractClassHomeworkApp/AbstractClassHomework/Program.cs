using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IInventoryItem> items = new List<IInventoryItem>();

            items.Add(new Book { ProductName = "The Alchemist", Author = "Paulo Coelho", NumOfPages = 250 });
            items.Add(new Clothing { ProductName = "Effortless Trouser", Type = "bottoms", Size = "S" });
            items.Add(new Book { ProductName = "Dune", NumOfPages = 350 });
            items.Add(new Clothing { ProductName = "Classic Blazer", Type = "Outerwear", Gender = "women", Size = "M" });

            Console.ReadLine();
        }
    }
}
