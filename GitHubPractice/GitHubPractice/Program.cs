using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name");
            string input = Console.ReadLine();

            output = ProcessStep1(input);
            Console.WriteLine(output);
            output = ProcessStep2(input);
            Console.WriteLine(output);
            output = ProcessStep3(input);
            Console.WriteLine(output);

        }
    }
}
