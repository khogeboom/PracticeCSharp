using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment06._17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new();
            string answer;

            do
            {
                Console.Write("Enter a name: ");
                names.Add(Console.ReadLine());

                Console.Write("Would you like to enter another name? ");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes" || answer.ToLower() == "y");

            File.WriteAllLines("ListOfNames.txt", names);

            Console.WriteLine();
            Console.WriteLine(File.ReadAllText("ListOfNames.txt"));


            Console.WriteLine();
            Console.WriteLine("Press any key to exit :)");
            Console.ReadKey();
        }
    }
}
