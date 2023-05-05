namespace ClassesBasics.Classes
{
    //Создать класс с именем Rectangle.
    //В теле класса создать два поля, описывающие длины сторон double side1, side2.
    //Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.
    //Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().
    //Создать два свойства double Area и double Perimeter с одним методом доступа get.
    
    internal class Rectangle
    {
        private double firstSide;
        private double secondSide;


        public double Area { get => CalculateArea(); }
        public double Perimetr { get => CalculatePerimetr(); }


        public Rectangle(double firstSide, double secondSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
        }


        private double CalculateArea() => firstSide * secondSide;


        private double CalculatePerimetr() => 2 * (firstSide + secondSide);
    }
}
