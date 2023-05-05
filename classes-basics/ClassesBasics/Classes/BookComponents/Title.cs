namespace ClassesBasics.Classes.BookComponents
{
    internal class Title
    {
        private string text;

        public string Text
        {
            get { return text; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException(value, "The value couldn't be empty or contain only whitespaces.");
                text = value;
            }
        }

        public Title() : this("Notitle") { }

        public Title(string text)
        {
            this.text = text;
        }


        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(Text);
            Console.WriteLine(new string('-', Text.Length));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
