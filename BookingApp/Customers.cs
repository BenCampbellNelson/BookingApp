using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp
{
   public class Customers
    {
        private string name;
        private string address;
        private string email;
        private int number;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public int Number { get => number; set => number = value; }

        public Customers(string _name, string _address, string _email, int _number)
        {
            this.name = _name;
            this.address = _address;
            this.email = _email;
            this.number = _number;
        }

     
    }
}
