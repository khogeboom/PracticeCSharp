using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            person.FirstName = "Tim";
            person.LastName = "Corey";

            Console.WriteLine($"{person.FirstName} {person.LastName}");

            Console.ReadLine();
        }
    }
}
