using System;

namespace Assignment06._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageText;
            bool isValidAge;
            string firstName;

            do
            {
                Console.Write("What is your first name? ");
                firstName = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(firstName));


            do
            {
                Console.Write("What is your age? ");
                ageText = Console.ReadLine();

                isValidAge = int.TryParse(ageText, out age);

            } while (isValidAge == false);

            age = Math.Abs(age);


            if (age >= 1 && age <= 17)
            {
                Console.WriteLine("Get off Tik Tok!!");
            }
            else if (age >= 18 && age <= 66)
            {
                Console.WriteLine("You're just counting down the days to retirement.");
            }
            else if (age >= 67 && age < 100)
            {
                Console.WriteLine("How's retirement??");
            }
            else if (age >= 100)
            {
                Console.WriteLine("Congrats on being older than the queen!!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit :)");
            Console.ReadKey();
        }
    }
}
