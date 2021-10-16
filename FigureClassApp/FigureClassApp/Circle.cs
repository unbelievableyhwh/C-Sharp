using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassApp
{
    class Circle: Figure
    {
        private double _rad;
        public double Radius
        {
            get { return _rad; }
            set { _rad = value; }
        }
        public Circle()
        {
            Radius = 5;
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public override void Draw()
        {
            Console.WriteLine("\nThis figure is Circle");
            Console.WriteLine($"radius = {Radius}");
        }

        public override double GetPerimetr()
        {
            double perm = 2* Radius * Math.PI;
            return perm;
        }
        public override double GetSquare()
        {
            double sqr = Math.PI * Math.Pow(Radius, 2);
            return sqr;
        }
        public void GetObjectWrite(Circle cir)
        {
            Console.WriteLine($"Type of this object - {cir.GetType()}");
            Console.WriteLine($"Hashcode of this object - {cir.GetHashCode()}");
        }
        public override void GetWrite()
        {
            Draw();
            Console.WriteLine($"Perimetr of this circle = {GetPerimetr()}");
            Console.WriteLine($"Square of this circle = {GetSquare()}");
            GetObjectWrite(this);
        }
    }
}
