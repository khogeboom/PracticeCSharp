using System;

namespace Assignment06._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the person's name? ");
            string name = Console.ReadLine();

            int age;
            Console.Write("How old are they? ");
            string ageText = Console.ReadLine();
            age = int.Parse(ageText);

            Console.Write("Is this person alive (true or false)? ");
            bool aliveOrDead = bool.Parse(Console.ReadLine());

            string phoneNum;
            Console.Write("What is their phone number? ");
            phoneNum = Console.ReadLine();

            //(555)555 - 1234
            // 555 - 555 - 1234
            // 55555551234
            // + 155555551234

            string zipCode;
            Console.Write("What is their zip code? ");
            zipCode = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Name: { name }");
            Console.WriteLine($"Age: { age }");
            Console.WriteLine($"Alive or Dead: { aliveOrDead }");
            Console.WriteLine($"Phone Number: { phoneNum }");
            Console.WriteLine($"Zip code: { zipCode }");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
