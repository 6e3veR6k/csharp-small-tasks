namespace ClassesBasics.Classes
{
    internal class Figure
    {
        private Point[] verticesPoints;
        private (int NumberOfVertices, string Name)[] namesOfFigures =
        {
            (NumberOfVertices: 3, Name: "Triangle"),
            (NumberOfVertices: 4, Name: "Quadrilateral"),
            (NumberOfVertices: 5, Name: "Pentagon"),
            (NumberOfVertices: 6, Name: "Hexahedron"),
            (NumberOfVertices: 7, Name: "Eptahedron"),
            (NumberOfVertices: 8, Name: "Octahedron "),
            (NumberOfVertices: 9, Name: "Nonagon"),
            (NumberOfVertices: 10, Name: "Decagon")
        };

        public double Perimetr
        {
            get; private set;
        }

        public string Name
        {
            get => namesOfFigures.First(tuple => tuple.NumberOfVertices == verticesPoints.Length).Name;
        }

        public Figure(params Point[] points)
        {
            verticesPoints = points;
            PerimeterCalculator();
        }

        private double LengthSide(Point firstPoint, Point secondPoint)
        {
            // TODO: Формула расчета длины отрезка по двум точкам
            return Math.Sqrt(Math.Pow(secondPoint.XCoordinate - firstPoint.XCoordinate, 2) + Math.Pow(secondPoint.YCoordinate - firstPoint.YCoordinate, 2));
        }

        private void PerimeterCalculator()
        {
            // TODO: Формула периметра
            double perimetr = 0;

            for(int i = 0; i < verticesPoints.Length - 1; i++)
            {
                perimetr += LengthSide(verticesPoints[i], verticesPoints[i+1]);

                if(i == verticesPoints.Length - 2)
                {
                    perimetr += LengthSide(verticesPoints[i+1], verticesPoints[0]);
                }
            }

            Perimetr = perimetr;
        }
    }
}
