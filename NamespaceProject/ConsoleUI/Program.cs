using System;
using ConsoleUI.Models;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel(); // from ConsoleUI.Models namespace
            person.FirstName = "Kasey";
            person.LastName = "Hogeboom";

            Console.ReadLine();
        }
    }
}
