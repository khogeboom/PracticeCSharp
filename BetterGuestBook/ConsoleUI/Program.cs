using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

// Capture the information about each guest (assume at least one guest and no max)
// Information: first name, last name, message to the host
// After information is collected: loop through each guest and print their info

namespace ConsoleUI
{
    internal class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {

            GetGuestInfo();

            PrintGuestInfo();

            Console.ReadLine();
        }

        private static void PrintGuestInfo()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static void GetGuestInfo()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("Enter first name: ");
                guest.LastName = GetInfoFromConsole("Enter last name: ");
                guest.MessageToHost = GetInfoFromConsole("Enter your message to the hose: ");
                guests.Add(guest);

                moreGuestsComing = GetInfoFromConsole("Are there more guests coming (yes/no)? ");

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.WriteLine(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
// PRO TIP: Design your app with just UI content in the UI. Put everything else in a class library.
// HOMEWORK: Recreate the guest book project without looking back.