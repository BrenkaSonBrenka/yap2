using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yap2
{
    public abstract class GeometricFigure
    {
        public int FigureIndex { get; protected set; }

        public string Name { get; protected set; }

        public double Square { get; protected set; }

        public double Perimeter { get; protected set; }

        public GeometricFigure() { }

        public abstract double SquareFunc();

        public abstract double PerimeterFunc();

        public abstract void GetInfo();
    }
}
