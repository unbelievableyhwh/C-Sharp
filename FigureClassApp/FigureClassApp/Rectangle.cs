using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassApp
{
    class Rectangle: Figure
    {
        private double _aside, _bside;
        public double ASide
        {
            get { return _aside; }
            set { _aside = value; }
        }
        public double BSide
        {
            get { return _bside; }
            set { _bside = value; }
        }
        public Rectangle()
        {
            ASide = 2;
            BSide = 2;
        }
        public Rectangle(double a, double b)
        {
            ASide = a;
            BSide = b;
        }
        public override void Draw()
        {
            Console.WriteLine("This figure is Rectangle");
            Console.WriteLine($"side a = {ASide}, side b = {BSide}");
        }

        public override double GetPerimetr()
        {
            double perm = 2 * (ASide + BSide);
            return perm;
        }
        public override double GetSquare()
        {
            double sqr = ASide * BSide;
            return sqr;
        }
        public void GetObjectWrite(Rectangle rectan)
        {
            Console.WriteLine($"Type of this object - {rectan.GetType()}");
            Console.WriteLine($"Hashcode of this object - {rectan.GetHashCode()}");
        }
        public override void GetWrite()
        {
            Draw();
            Console.WriteLine($"Perimetr of this rectangle = {GetPerimetr()}");
            Console.WriteLine($"Square of this rectangle = {GetSquare()}");
            GetObjectWrite(this);
        }
    }
}
