using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInsulter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings. Press 1, 2, or 3 to be insulted, or q to quit.");
            int choice = Convert.ToInt32(Console.ReadLine());

            GetInsult(choice);

            Console.ReadKey();
        }

        private static void GetInsult(int choice)
        {
            throw new NotImplementedException();
        }
    }
}