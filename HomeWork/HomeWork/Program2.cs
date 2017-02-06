using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program2
    {
        public static void Main()
        {
            Console.WriteLine("Entrance Ticket : $25.");
            Console.WriteLine("PLease enter the number of ticket you want");

            string input = Console.ReadLine(); //input is a string, convert the string "25" into a integer
            double NumTix = Convert.ToDouble(input);
            Console.WriteLine("The Total cost is {0}", NumTix*25); 

        }
    }
}
