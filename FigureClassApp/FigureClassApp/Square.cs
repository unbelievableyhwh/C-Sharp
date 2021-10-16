using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassApp
{
    class Square: Rectangle
    {
        private double _aside;
        public double ASide
        {
            get { return _aside; }
            set { _aside = value; }
        }
        public Square()
        {
            ASide = 2;
        }
        public Square(double a)
        {
            ASide = a;
        }
        public override void Draw()
        {
            Console.WriteLine("\nThis figure is Square");
            Console.WriteLine($"side a = {ASide}");
        }

        public override double GetPerimetr()
        {
            double perm = 4 * ASide;
            return perm;
        }
        public override double GetSquare()
        {
            double sqr = Math.Pow(ASide,2);
            return sqr;
        }
        public void GetObjectWrite(Square sqw)
        {
            Console.WriteLine($"Type of this object - {sqw.GetType()}");
            Console.WriteLine($"Hashcode of this object - {sqw.GetHashCode()}");
        }
        public override void GetWrite()
        {
            Draw();
            Console.WriteLine($"Perimetr of this square = {GetPerimetr()}");
            Console.WriteLine($"Square of this square = {GetSquare()}");
            GetObjectWrite(this);
        }
    }
}
