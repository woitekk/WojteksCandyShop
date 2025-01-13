using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WojteksCandyShop.HR
{
    public class Address
    {
        private string street;
        private string houseNum;
        private string city;
        private string postalCode;

        public Address(string street, string houseNum, string city, string postalCode)
        {
            Street = street;
            HouseNum = houseNum;
            City = city;
            PostalCode = postalCode;
        }

        public string Street
        {
            get; set;
        }
        public string HouseNum
        {
            get; set;
        }
        public string City
        {
            get; set;
        }
        public string PostalCode
        {
            get; set;
        }
    }
}
