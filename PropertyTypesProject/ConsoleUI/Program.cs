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
            AddressModel address = new AddressModel();
            address.StreetAddress = "123 Name St";
            address.City = "New York";
            address.State = "NY";
            address.ZipCode = "10023";

            Console.WriteLine(address.FullAddress);

            Console.ReadKey();
        }
    }
}
