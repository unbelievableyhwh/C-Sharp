using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FucktorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 2;
            int max = 7;
            int sum = 1;
            for(int i = min; i <= max; i++)
            {
                string text = $"{sum} * {i} = ";
                sum *= i;
                Console.WriteLine(text + sum);
            }
            Console.WriteLine($"\nФакториал {max} = " + sum);

            Console.ReadKey();
        }
    }
}
