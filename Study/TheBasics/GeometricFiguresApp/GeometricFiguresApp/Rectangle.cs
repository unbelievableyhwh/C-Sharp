using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresApp
{
    class Rectangle
    {
        public int _aside;
        public int _bside;

        public Rectangle()
        {
            _aside = 1;
            _bside = 1;
        }

        public Rectangle(int a, int b)
        {
            _aside = a;
            _bside = b;
        }

        public int ASide
        {
            get { return _aside; }
            set { _aside = value; }
        }
        public int BSide
        {
            get { return _bside; }
            set { _bside = value; }
        }
    }
}
