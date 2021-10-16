using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureClassApp
{
    abstract class Figure
    {
        public abstract void Draw();
        public abstract double GetPerimetr();
        public abstract double GetSquare();
        public abstract void GetWrite();
    }
}
