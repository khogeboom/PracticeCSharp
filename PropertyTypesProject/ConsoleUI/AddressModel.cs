using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string FullAddress
        {
            get 
            {
                return $"{StreetAddress}, {City}, {State} {ZipCode}";
            }
        }

    }
}
