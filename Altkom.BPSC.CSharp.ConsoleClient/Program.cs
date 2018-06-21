using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassTest();

            // ConsoleTest();
        }


        static void ClassTest()
        {
            Console.WriteLine("Podaj imię:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Podaj numer");
            byte number = byte.Parse(Console.ReadLine());

            int age = 100;

            // deklaracja zmiennej typu Customer
            Customer klient;

            // ...

            // tworzy instancję klasy czyli obiekt
            klient = new Customer();
            klient.FirstName = "Marcin";
            klient.LastName = "Sulecki";

            klient.Print();

            // inicjalizator
            Customer klient2 = new Customer()
            {
                FirstName = "Marcin",
                LastName = "Sulecki",
            };
            


        }

        static void ConsoleTest()
        {
            Console.WriteLine("Podaj imię:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Podaj wiek");
            byte age = byte.Parse(Console.ReadLine());

            // konkatenacja (zła praktyka)
            Console.WriteLine("Witaj " + firstName + " " + lastName);

            string message1 = string.Format("Witaj {0} {1}", firstName, lastName);

            string ageStr = age.ToString();

            // C# 6.0 interpolacja
            string message2 = $"Witaj {firstName} {lastName} {age}";

            // Z zasobu
            string message = string.Format(Properties.Resources.Welcome, firstName, lastName);
            Console.WriteLine(message);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
