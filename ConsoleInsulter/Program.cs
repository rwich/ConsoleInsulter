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
            Console.WriteLine("Greetings. Press 1, 2, or 3 to be insulted, or 0 to quit.");
            byte choice;

            try
            {
                choice = Convert.ToByte(Console.ReadLine());
                if (choice == 0 || choice == 1 || choice == 2 || choice == 3)
                {
                    PrintInsult(choice);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("You must enter a number from 0 to 3. (press Enter)");
            }
            
            Console.ReadKey();
        }           

        private static void PrintInsult(int choice)
        {
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Farewell. May the wind always be in your face. (press Enter)");
                    break;
                case 1:
                    Console.WriteLine("Your mother dresses you funny. (press Enter)");
                    break;
                case 2:
                    Console.WriteLine("Your feet smell like cheese. (press Enter)");
                    break;
                case 3:
                    Console.WriteLine("You have the intellect of a rubber chicken. (press Enter)");
                    break;
            }
        }
    }
}