using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp
{
    internal class Customers
    {
        private string name;
        private string address;
        private int number;
        private string email;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }

        public Customers(string _name, string _address, int _number, string _email)
        {
            name = _name;
            address = _address;
            number = _number;
            email = _email;
        }













    }
}
