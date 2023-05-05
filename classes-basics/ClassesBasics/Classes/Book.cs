using ClassesBasics.Classes.BookComponents;

namespace ClassesBasics.Classes
{
    //Создать класс Book.Создать классы Title, Author и Content, каждый из которых
    //должен содержать одно строковое поле и метод void Show().
    //Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
    //Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
    internal class Book
    {
        Title title;
        Author author;
        Content content;

        public string Title
        {
            get
            {
                return title.Text;
            }
            set 
            {
                try
                {
                    title.Text = value;
                } catch (ArgumentException e)
                {
                    Console.WriteLine("Exception caught creating title with empty string.");
                    Console.WriteLine(e.Message);
                }
            }
        }

        public string Author
        {
            get
            {
                return author.Name;
            }
            set
            {
                try
                {
                    author.Name = value;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Exception caught creating author with empty string.");
                    Console.WriteLine(e.Message);
                }
            }
        }

        public string Content
        {
            get
            {
                return content.Body;
            }
            set
            {
                try
                {
                    content.Body = value;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Exception caught creating body with empty string.");
                    Console.WriteLine(e.Message);
                }
            }
        }


        void InitialiseComponents()
        {
            title = new Title();
            author = new Author();
            content = new Content();
        }

        public Book()
        {
            InitialiseComponents();
        }


        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }


    }
}
