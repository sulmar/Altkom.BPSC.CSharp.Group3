using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Komentarz
            Console.WriteLine("Hello World!");

            /* Komentarz blokowy 
             * druga linia
             * trzecia linia
            */

            // Przypisanie

            int number = 100;
            

            // Porównanie
            if (number == 99)
            {

            }

            if (number.Equals(99))
            {

            }

            // Różne
            if (number != 100)
                Console.WriteLine("Liczba różna od 100");
            else
            {
                Console.WriteLine("Liczba równa 100");
                Console.WriteLine("Liczba równa 100");
            }

            // 0..255
            byte age = 18;

            // iloczyn logiczny AND
            if (number > 100 && age > 18)
            {

            }

            // suma logiczna OR
            if (number > 100 || age > 18)
            {

            }




            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
