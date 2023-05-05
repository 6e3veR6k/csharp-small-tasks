using ClassesBasics.Classes;
using System.ComponentModel;
using System.Net;

namespace ClassesBasics
{
    internal static class HomeWork
    {
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
    }
}
