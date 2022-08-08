using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// HOMEWORK: Create the following chain using extension methods: person.SetDefaultAge().PrintInfo();

namespace ExtensionMethodHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel();
            person.FirstName = "Tim";
            person.LastName = "Corey";
            person.SetDefaultAge().PrintInfo();

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }

    public static class ExtensionSamples
    {
        public static void PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} : {person.Age} years old");
        }

        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 18;
            return person;
        }
    }
}
