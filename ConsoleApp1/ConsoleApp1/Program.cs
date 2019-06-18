using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key...");

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key.Equals(ConsoleKey.A))
            {
                Console.WriteLine("You pressed A key!");
                Console.ReadKey();
            }
        }
    }
}
