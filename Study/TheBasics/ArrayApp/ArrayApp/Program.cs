using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                mass[i] = rnd.Next(0, 100);
                Console.WriteLine($"Элемент массива №{i} равен - {mass[i]}");
            }
            int min = mass[0];
            int max = mass[0];
            for(int i = 0; i < 10; i++)
            {
                if (mass[i] < min)
                {
                    min = mass[i];
                }
                if(mass[i] > max)
                {
                    max = mass[i];
                }
            }
            Console.WriteLine($"\nНаименьшее значение равно - {min}");
            Console.WriteLine($"\nНаибольшее значение равно - {max}");


            Console.ReadKey();
        }
    }
}
