using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            string firstName, lastName, emailAddress, streetAddress, state, city, zipCode;

            do
            {
                PersonModel person = new PersonModel();
                Console.Write("Enter first name (or exit to end): ");
                firstName = Console.ReadLine();
                
                if (firstName != "exit")
                {
                    person.FirstName = firstName;
                    Console.Write("Enter last name: ");
                    lastName = Console.ReadLine();
                    person.LastName = lastName;
                    Console.Write("Enter email address: ");
                    emailAddress = Console.ReadLine();
                    person.EmailAddress = emailAddress;
                    Console.Write("Enter street address: ");
                    streetAddress = Console.ReadLine();
                    person.Address.StreetAddress = streetAddress;
                    Console.Write("Enter city: ");
                    city = Console.ReadLine();
                    person.Address.City = city;
                    Console.Write("Enter state: ");
                    state = Console.ReadLine();
                    person.Address.State = state;
                    Console.Write("Enter zip code: ");
                    zipCode = Console.ReadLine();
                    person.Address.ZipCode = zipCode;
                    people.Add(person);
                }
            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName}");
                Console.WriteLine($"{p.EmailAddress}");
                Console.WriteLine($"{p.Address.StreetAddress}, {p.Address.City}, {p.Address.State} {p.Address.ZipCode}");
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
