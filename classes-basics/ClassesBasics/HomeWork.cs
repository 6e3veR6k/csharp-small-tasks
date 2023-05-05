using ClassesBasics.Classes;
using System.ComponentModel;
using System.Net;

namespace ClassesBasics
{
    internal static class HomeWork
    {
        #region HomeWorkTasks 1
        public static void TaskAlfaRun()
        {
            Address workAddress = new Address();
            workAddress.Country = "UA";
            workAddress.City = "Kyiv";
            workAddress.Street = "Zdolbunivska";
            workAddress.House = "17Б";
            workAddress.Apartment = "IT";
            workAddress.Index = "02320";


            Address homeAddress = new Address
            {
                Country = "UA",
                City = "Kyiv",
                Street = "Vozzednannya",
                House = "1/10",
                Apartment = "65Б",
                Index = "02210"
            };

            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"I work at the address of\n\tAp. {workAddress.Apartment}, {workAddress.House} {workAddress.Street} St.\n\t{workAddress.City}, {workAddress.Country} {workAddress.Index}");
            Console.WriteLine(new string('-', 40));
            Console.WriteLine($"I live at the address of\n\tAp. {homeAddress.Apartment}, {homeAddress.House} {homeAddress.Street} St.\n\t{homeAddress.City}, {homeAddress.Country} {homeAddress.Index}");
            Console.WriteLine(new string('-', 40));
        }


        public static void TaskBravoRun()
        {
            //Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит  на экран периметр и площадь.
            double firstRectangleSide = GetValidInputValue("Enter first side of rectangle: ");
            double secondRectangleSide = GetValidInputValue("Enter second side of rectangle: ");

            Rectangle userRectangle = new Rectangle(firstRectangleSide, secondRectangleSide);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Your rectangle's area is equal to {userRectangle.Area:F3} and its perimetr is equal {userRectangle.Perimetr:F3}");

        }


        public static void TaskCharlieRun()
        {
            Book book = new Book();

            book.Title = GetValidString("Enter book title: ");
            book.Author = GetValidString("Enter book author: ");
            book.Content = GetValidString("Enter body of the book: ");

            book.Show();
        }
        #endregion



        #region UserInterface
        private static double GetValidInputValue(string messageForInput)
        {
            double userInputValue;
            Console.Write(messageForInput);

            while (!double.TryParse(Console.ReadLine(), out userInputValue) || userInputValue <= 0)
            {
                Console.WriteLine("You entered wrong data...");
                Console.Write(messageForInput);
            }

            return userInputValue;
        }


        private static string GetValidString(string messageForInput)
        {
            Console.Write(messageForInput);
            bool isStringValid = false;
            string userString = default;

            while (!isStringValid)
            {
                userString = Console.ReadLine();
                isStringValid = !string.IsNullOrWhiteSpace(userString);

                if (!isStringValid) { Console.WriteLine("The string could not be empty or contain only spaces."); }
            }

            return userString;
        }

        #endregion

    }
}
