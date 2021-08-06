using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment06._18
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText;
            int input;

            do
            {
                Console.Clear();
                MainMenu();
                Console.WriteLine();
                Console.Write("Type the number of what you would like: ");
                inputText = Console.ReadLine();
                Console.WriteLine();
                int.TryParse(inputText, out input);

                if (input == 1)
                {
                    Console.Clear();
                    DisplayGuestBook();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    AddGuests();
                }
                else if (input == 3)
                {
                    Console.Clear();
                    RemoveGuests();
                }
                else if (input == 4)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR. Invalid input.");
                    GoBackToMain();
                }

            } while (input != 4);

        }

        private static void MainMenu()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("**** Welcome to the Guest Book app ****");
            Console.WriteLine("***************************************");
            Console.WriteLine();
            Console.WriteLine("\t1. Display the Guest Book");
            Console.WriteLine("\t2. Add Guest(s)");
            Console.WriteLine("\t3. Remove Guest(s)");
            Console.WriteLine("\t4. Exit the app");

        }

        private static void DisplayGuestBook()
        {
            if (!File.Exists("GuestBook.txt") || string.IsNullOrWhiteSpace(File.ReadAllText("GuestBook.txt")))
            {
                Console.WriteLine("Guest Book is currently empty.");
            }
            else if (File.Exists("GuestBook.txt"))
            {
                Console.WriteLine(File.ReadAllText("GuestBook.txt"));
            }

            GoBackToMain();
        }

        private static void AddGuests()
        {
            string answer;
            List<string> parties = File.ReadAllLines("GuestBook.txt").ToList();

            do
            {
                string partyName = GetPartyName ();
                int numInParty = GetPartyNum();

                parties.Add($"{partyName}, party of {numInParty}");

                Console.Write("Would you like to enter another party? ");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes" || answer.ToLower() == "y");

            File.WriteAllLines("GuestBook.txt", parties);
            GoBackToMain();
        }

        private static string GetPartyName()
        {
            string partyName;

            do
            {
                Console.Write("Enter the name of your party: ");
                partyName = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(partyName) == false && partyName.Length >= 3)
                {
                    break;
                }

                Console.WriteLine("ERROR. Please enter a valid name.");

            } while (string.IsNullOrWhiteSpace(partyName) || partyName.Length < 3);

            return partyName;
        }

        private static int GetPartyNum()
        {
            bool isValidNum;
            int numInParty;

            do
            {
                Console.Write("Enter the number of people in your party: ");
                string numInPartyText = Console.ReadLine();
                isValidNum = int.TryParse(numInPartyText, out numInParty);

                if(isValidNum == false || numInParty > 20 || numInParty < 0 || numInParty % 1 != 0)
                {
                    Console.WriteLine("ERROR. Please enter a valid number.");
                    isValidNum = false;
                }
                else if (isValidNum && numInParty > 0 && numInParty <= 20 && numInParty % 1 == 0)
                {
                    break;
                }

            } while (isValidNum == false);

            return numInParty;
        }

        private static void RemoveGuests()
        {
            string partyName;
            string answer;
            List<string> parties = File.ReadAllLines("GuestBook.txt").ToList();

            do
            {
                Console.Write("Enter the name of the party you would like to remove: ");
                partyName = Console.ReadLine();

                CheckPartyName(parties, partyName);

                Console.WriteLine();
                Console.Write("Would you like to remove another party? ");
                answer = Console.ReadLine();

            } while (answer.ToLower() == "yes" || answer.ToLower() == "y");

            File.WriteAllLines("GuestBook.txt", parties);
            GoBackToMain();
        }

        private static List<string> CheckPartyName(List<string> parties, string partyName)
        {
            bool isValidName = false;

            foreach (var party in parties)
            {
                if (party.ToLower().Contains(partyName.ToLower()))
                {
                    Console.WriteLine($"{ party } was removed from the Guest Book.");
                    parties.Remove(party);
                    isValidName = true;
                    break;
                }
            }

            if (isValidName == false)
            {
                Console.WriteLine("No such party exists.");
            }

            return parties;
        }

        private static void GoBackToMain()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to go back to the main menu.");
            Console.ReadKey();
        }

    }
}
