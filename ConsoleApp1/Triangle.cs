namespace yap2
{
    class Triangle : GeometricFigure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (a == b && a == c)
                Name = "Равностороннмй треугольник";
            else if (a == b || b == c || a == c)
                Name = "Равнобедренный треугольник";
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                Name = "Прямоугольный треугольник";
            else
                Name = "Разносторонний треугольник";
            FigureIndex = 3;
        }

        public override double PerimeterFunc()
        {
            Perimeter = a + b + c;
            return Perimeter;
        }
        public override double SquareFunc()
        {
            double p = (a + b + c) / 2;
            Square = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
            return Square;
        }

        public override void GetInfo()
        {
            Console.WriteLine("{0} со сторонами {1}, {2} и {3} имеет периметр равный {4}, площадь равную {5}", Name, a, b, c, PerimeterFunc(), SquareFunc());
        }
    }
}
