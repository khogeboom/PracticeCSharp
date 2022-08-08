using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// HOMEWORK: Create a generic method that takes in an item and calls the ToString() method and prints that value to the Console.

namespace GenericsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericMethod("test");
            GenericMethod(1);
            GenericMethod(2.3);
            GenericMethod(true);

            Console.ReadLine();
        }

        static void GenericMethod<T>(T item)
        {
            string output = item.ToString();
            Console.WriteLine(output);
        }
    }
}
