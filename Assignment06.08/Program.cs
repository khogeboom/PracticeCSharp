using System;

namespace Assignment06._08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop for firstname, such that it's non-empty
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            // Loop around age, such that it's a valid int.
            Console.Write("How old are you? ");
            string ageText = Console.ReadLine();


            if (string.IsNullOrWhiteSpace(ageText))
            {
                Console.WriteLine("ERROR... no age value given.");
            }
            else // if (!string.IsNullOrWhiteSpace(ageText))
            {
                int age = int.Parse(ageText);
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
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
