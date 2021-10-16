using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure rec = new Rectangle(4, 6);
            rec.GetWrite();
            Figure trn = new Triangle(4, 4, 7);
            trn.GetWrite();
            Figure crl = new Circle(3);
            crl.GetWrite();
            Rectangle square = new Square(6);
            square.GetWrite();



            Console.ReadKey();
        }
    }
}
