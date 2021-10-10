using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresApp
{
    class Triangle
    {
        public int _aside;
        public int _bside;
        public int _cside;

        public Triangle()
        {
            _aside = 2;
            _bside = 2;
            _cside = 2;
        }
        public Triangle(int a, int b, int c)
        {
            _aside = a;
            _bside = b;
            _cside = c;
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
        public int CSide
        {
            get { return _cside; }
            set { _cside = value; }
        }

    }
}
