using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassApp
{
    class Triangle: Figure
    {
        private double _aside, _bside, _cside;
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
        public double CSide
        {
            get { return _cside; }
            set { _cside = value; }
        }
        public Triangle()
        {
            ASide = 3;
            BSide = 3;
            CSide = 3;
        }
        public Triangle(double a, double b, double c)
        {
            ASide = a;
            BSide = b;
            CSide = c;
        }
        public override void Draw()
        {
            Console.WriteLine("\nThis figure is Triangle");
            Console.WriteLine($"side a = {ASide}, side b = {BSide}, side c = {CSide}");
        }

        public override double GetPerimetr()
        {
            double perm = ASide + BSide + CSide;
            return perm;
        }
        public override double GetSquare()
        {
            double sqr, pp;
            pp = (ASide + BSide + CSide) / 2;
            sqr = Math.Sqrt(pp * (pp - ASide) * (pp - BSide) * (pp - CSide));
            return sqr;
        }
        public void GetObjectWrite(Triangle trian)
        {
            Console.WriteLine($"Type of this object - {trian.GetType()}");
            Console.WriteLine($"Hashcode of this object - {trian.GetHashCode()}");
        }
        public override void GetWrite()
        {
            Draw();
            Console.WriteLine($"Perimetr of this triangle = {GetPerimetr()}");
            Console.WriteLine($"Square of this triangle = {GetSquare()}");
            GetObjectWrite(this);
        }
    }
}
