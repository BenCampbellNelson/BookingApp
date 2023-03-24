using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp
{
    public class Tour
    {
        private string name;
        private string date;
        private string location;
        private int seats = 0;

        public Tour(string name, string date, string location, int seats)
        {
            this.name = name;
            this.date = date;
            this.location = location;
            this.seats = seats;
        }

        public string Name { get => name; set => name = value; }
        public string Date { get => date; set => date = value; }
        public string Location { get => location; set => location = value; }
        public int Seats { get => seats; set => seats = value; }
    }
}
