using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06._22
{
    class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public AddressModel()
        {

        }

        public AddressModel(string streetAddress)
        {
            StreetAddress = streetAddress;
        }

        public override string ToString()
        {
            string output = $"{StreetAddress}\n{City}, {State}\n{ZipCode}";
            
            string altOutput = StreetAddress + Environment.NewLine;
            altOutput += City + ", " + State + Environment.NewLine;
            altOutput += ZipCode;

            string nl = Environment.NewLine;
            string altOutput2 = $"{StreetAddress}{nl}{City}, {State}{nl}{ZipCode}";

            return altOutput2;
        }

        public string FullAddress
        {
            get { return $"{ StreetAddress }, { City }, { State } {ZipCode }"; }
        }
    }
}
