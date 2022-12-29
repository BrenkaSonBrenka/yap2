namespace yap2
{
    class Ellipse : GeometricFigure
    {
        private double radius_1;
        private double radius_2;


        public Ellipse(double r1, double r2)
        {
            if (r1 == r2)
            {
                Name = "Круг";
            }
            else
            {
                Name = "Овал";
            }
            radius_1 = r1;
            radius_2 = r2;

            FigureIndex = 1;
        }

        public override double PerimeterFunc()
        {
            Perimeter = Math.Round(4 * (Math.PI * radius_1 * radius_2 + Math.Pow((radius_1 - radius_2), 2)) / (radius_1 + radius_2));

            return Perimeter;
        }
        public override double SquareFunc()
        {
            Square = Math.Round(radius_1 * radius_2 * Math.PI);

            return Square;
        }
        public override void GetInfo()
        {
            if (radius_1 == radius_2)
            {
                Console.WriteLine("{0} с радиусам {1} имеет периметр равный {2}, площадь равную {3}", Name, radius_1, PerimeterFunc(), SquareFunc());
            }
            else
            {
                Console.WriteLine("{0} с радиусами {1} и {2} имеет периметр равный {3}, площадь равную {4}", Name, radius_1, radius_2, PerimeterFunc(), SquareFunc());
            }
        }

    }
}
