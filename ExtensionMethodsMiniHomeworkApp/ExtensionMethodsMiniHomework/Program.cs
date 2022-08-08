using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsMiniHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "Enter your first name: ".RequestString();

            person.LastName = "Enter your last name: ".RequestString();

            person.BankAccount = "Enter the amount in your bank account: ".RequestDouble();

            person.IsMarried = "Are you married (yes/no): ".RequestBool();

            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BankAccount { get; set; }
        public bool IsMarried { get; set; }
    }

    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static double RequestDouble(this string message)
        {
            double output = 0;
            bool isValidAmount = false;

            while(isValidAmount == false)
            {
                Console.Write(message);
                isValidAmount = double.TryParse(Console.ReadLine(), out output);

                if (output < 0)
                    isValidAmount = false;
            }

            return output;
        }

        public static bool RequestBool(this string message)
        {
            bool output = false;
            string answer = "";
            while (string.IsNullOrWhiteSpace(answer))
            {
                Console.Write(message);
                answer = Console.ReadLine();

                if (answer.ToLower() == "yes")
                    output = true;
                else if (answer.ToLower() == "no")
                    output = false;
                else
                    answer = "";
            }

            return output;
        }
    }
}
