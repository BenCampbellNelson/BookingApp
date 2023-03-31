using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp
{
    internal class Menu
    {
        static void menu()
        {
            Console.WriteLine("1:tour available\n2:book tour\n3:add tour\n4:cancel tour");
            switch(Console.ReadLine()) 
            {
                case "1":
                    Console.WriteLine("tour 1 3 5 are available");
                break;
                case "2":
                    Console.WriteLine(" 2 or 4");
                break;
                case "3":
                    Console.WriteLine();
                break;
                case "4":
                    Console.WriteLine("1 2 3 4 5");
                 break;
            }
        }
    }
}
