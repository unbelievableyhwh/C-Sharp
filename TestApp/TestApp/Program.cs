using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate a random number...");
            Console.ReadKey();
            Random rnd = new Random();
            double rndnum = rnd.Next(245);
            Console.WriteLine(rndnum);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
