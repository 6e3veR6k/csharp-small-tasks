namespace ClassesBasics.Classes
{
    internal class Point
    {
        private int xCoordinate;
        private int yCoordinate;
        private string name;

        public int XCoordinate
        {
            get { return xCoordinate; }
        }

        public int YCoordinate
        {
            get { return yCoordinate; }
        }

        public string Name
        {
            get { return name; }
        }


        public Point(string name, int xCoordinate, int yCoordinate)
        {
            this.name = name;
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
        }
    }
}
