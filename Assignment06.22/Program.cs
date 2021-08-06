using System;
using System.Collections.Generic;

namespace Assignment06._22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> PersonAndAddress = new List<string>();

            PersonModel kasey = new PersonModel("Kasey", "Hogeboom");
            kasey.HomeAddress.StreetAddress = "242 Country Club Dr";
            PersonAndAddress.Add($"{kasey.FirstName} {kasey.LastName} lives at {kasey.HomeAddress.StreetAddress}");

            AddressModel someAddress = new();
            someAddress.StreetAddress = "123 Fake St";
            someAddress.City = "Springfield";
            someAddress.State = "OR";
            someAddress.ZipCode = "12345-1234";
            PersonModel brian = new("brian", "fontana", someAddress);

            Console.WriteLine("********");
            Console.WriteLine(someAddress.ToString());
            Console.WriteLine("********");

            AddressModel fakeAddress = new AddressModel
            {
                StreetAddress = "123 Fake St",
                City = "Springfield",
                State = "OR",
                ZipCode = "12345-1234"
            };
            PersonModel chiefWiggum = new("Clancy", "Wiggum", fakeAddress);

            PersonModel bob = new PersonModel("Bob", "Lob");
            bob.HomeAddress.StreetAddress = "123 Name St";
            PersonAndAddress.Add($"{bob.FirstName} {bob.LastName} lives at {bob.HomeAddress.StreetAddress}");

            PersonModel peter = new PersonModel("Peter", "Pan");
            peter.HomeAddress.StreetAddress = "123 Neverland Ave";
            PersonAndAddress.Add($"{ peter.FirstName } { peter.LastName } lives at { peter.HomeAddress.StreetAddress }");

            PersonModel buzz = new PersonModel("Buzz", "Lightyear");
            buzz.HomeAddress.StreetAddress = "123 Andy's Room Rd";
            PersonAndAddress.Add($"{ buzz.FirstName } { buzz.LastName } lives at { buzz.HomeAddress.StreetAddress }");

            PersonModel joe = new PersonModel("Joe", "Biden");
            joe.HomeAddress.StreetAddress = "1600 Pennsylvania Ave";
            PersonAndAddress.Add($"{ joe.FirstName } { joe.LastName } lives at { joe.HomeAddress.StreetAddress }");



            foreach (var entry in PersonAndAddress)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine($"THere are this many people constructed: {PersonModel.InstanceCounter}");

            Console.ReadKey();

        }

    }
}
