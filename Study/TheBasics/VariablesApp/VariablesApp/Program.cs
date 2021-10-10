using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("Please enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number:");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You've enter:"+ "\n" + a + "\n" + b + "\n" + c + "\n" + d);
            int sum = a + b + c + d;
            int mum = a * b * c * d;
            Console.WriteLine($"Their sum = {sum}");
            Console.WriteLine($"Their multiply = {mum}");


            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
