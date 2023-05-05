using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassesBasics.Classes.BookComponents
{
    internal class Content
    {
        private string body;

        public string Body
        {
            get { return body; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException(value, "The value couldn't be empty or contain only whitespaces.");
                body = value;
            }
        }

        public Content() : this("Empty...")
        {

        }


        public Content(string body)
        {
            this.body = body;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('=', Body.Length));
            Console.WriteLine($"{Body}");
            Console.WriteLine(new string('=', Body.Length));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
