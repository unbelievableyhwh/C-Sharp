using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAppFirst
{
    class Program
    {
        public class Cube
        {
            public int height, weight;
            public int Height
            {
                get { return height; }
                set { height = value; }
            }
            public int Weight
            {
                get { return weight; }
                set { weight = value; }
            }
            public int Leight { get; set; } 

            public int GetPerimetr()
            {
                int perm = 4 * (Height + Leight + Weight);
                return perm;
            }

            public int GetSquare()
            {
                int sqr = 2 * (Height * Leight + Leight * Weight + Height * Weight);
                return sqr;
            }

            public int GetVolume()
            {
                int vol = Weight * Height * Leight;
                return vol;
            }

        }
        static void Main(string[] args)
        {
            Cube _firstCube = new Cube();
            Console.WriteLine("pls enter Height:");
            _firstCube.Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pls enter Weight:");
            _firstCube.Weight = Convert.ToInt32(Console.ReadLine());
            _firstCube.Leight = _firstCube.Weight;
            Console.WriteLine($"\nPerimetr = {_firstCube.GetPerimetr()}");
            Console.WriteLine($"\nSquare = {_firstCube.GetSquare()}");
            Console.WriteLine($"\nVolume = {_firstCube.GetVolume()}");

            Console.ReadKey();
        }
    }
}
