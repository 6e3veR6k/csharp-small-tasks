namespace ClassesBasics.Classes.BookComponents
{
    internal class Author
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException(value, "The value couldn't be empty or contain only whitespaces.");
                name = value;
            }
        }


        public Author() : this("Noname") { }


        public Author(string name)
        {
            this.name = name;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The author of the book is {Name}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
