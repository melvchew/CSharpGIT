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
            Console.Write("Enter your name: \t");
            string input = Console.ReadLine();
            string output;
            output = ProcessStep1(input);
            Console.WriteLine(output);
            output = ProcessStep2(input);
            Console.WriteLine(output);
            output = ProcessStep3(input);
            Console.WriteLine(output);

        }

        public static string ProcessStep1(string s)
        {
            return s;
        }
        public static string ProcessStep2(string s)
        {
            return s;
        }
        public static string ProcessStep3(string s)
        {
            return s;
        }
    }
}
