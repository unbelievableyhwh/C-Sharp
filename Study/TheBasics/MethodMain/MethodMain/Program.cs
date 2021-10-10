using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodMain
{
    class Program
    {
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            foreach (string s in args)
                Console.WriteLine(s);
            string fullpath = Environment.GetCommandLineArgs()[0];

            Console.ReadKey();
        }
    }
}
