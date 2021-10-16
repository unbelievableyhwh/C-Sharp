using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAMGHOUL
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;
            Console.ForegroundColor = ConsoleColor.Green;
            while (x > 7)
            {
                Console.Write($"{x} - 7 = ");
                x = x - 7;
                Console.WriteLine(x);
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("I'm a GHOUL!");

            Console.ReadKey();
        }
    }
}
