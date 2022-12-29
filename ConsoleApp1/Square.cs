namespace yap2
{
    internal class Square : GeometricFigure
    {
        private double a;
        private double b;

        public Square(double a, double b)
        {
            if (a == b)
            {
                Name = "Квадрат";
            }
            else
            {
                Name = "Прямоугольник";
            }
            this.a = a;
            this.b = b;
            FigureIndex = 2;
        }

        public override double PerimeterFunc()
        {
            Perimeter = (a + b) * 2;
            return Perimeter;
        }
        public override double SquareFunc()
        {
            Square = a * b;
            return Square;
        }
        public override void GetInfo()
        {
            if (a == b)
            {
                Console.WriteLine("{0} со стороной {1} имеет периметр равный {2}, площадь равную {3}", Name, a, PerimeterFunc(), SquareFunc());
            }
            else
            {
                Console.WriteLine("{0} со сторонами {1} и {2} имеет периметр равный {3}, площадь равную {4}", Name, a, b, PerimeterFunc(), SquareFunc());
            }
        }
    }
}
