using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresApp
{
    class Program
    {
        public static int GetPerimetr(int a, int b, int c)
        {
            int perm = a + b + c;
            return perm;
        }
        public static int GetPerimetr(int a, int b)
        {
            int perm = 2 * (a + b);
            return perm;
        }
        public static int GetSquare(int a, int b)
        {
            int sqr = a * b;
            return sqr;
        }
        public static double GetSquare(int a, int b, int c)
        {
            double sqr, pp;
            pp = (a + b + c) / 2;
            sqr = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
            return sqr;
        }
        static void Main(string[] args)
        {
            int a, b, c, d, f;
            Console.WriteLine("pls enter a side of triangle:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pls enter a side of rectangle:");
            d = Convert.ToInt32(Console.ReadLine());
            f = Convert.ToInt32(Console.ReadLine());
            Triangle trg = new Triangle(a, b, c);
            Rectangle rcg = new Rectangle(d, f);
            Console.WriteLine($"\nPerimetr of triangle = {GetPerimetr(trg.ASide, trg.CSide, trg.BSide)}, of rectangle = {GetPerimetr(rcg.ASide, rcg.BSide)}");
            Console.WriteLine($"\nSquare of triangle = {GetSquare(trg.ASide, trg.CSide, trg.BSide)}, of rectangle = {GetSquare(rcg.ASide, rcg.BSide)}");


            Console.ReadKey();
        }
    }
}
