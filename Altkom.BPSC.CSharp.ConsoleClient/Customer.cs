using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.ConsoleClient
{
    // notacja Pascalowa (Pascal Case)
    class Customer
    {
        // notacja wielbłądzia (Camel Case)
        private string firstName;
        
        private byte? number;

        // notacja Pascalowa

        // Właściwość (property)
        public string FirstName
        {
            set
            {
                this.firstName = value;
            }

            get
            {
                return this.firstName;
            }
        }

        public string LastName { get; set; }

        //public void SetFirstName(string firstName)
        //{
        //    this.firstName = firstName;
        //}

        //public string GetFirstName()
        //{
        //    return this.firstName;
        //}


        // pole moze przyjmowac wartosc null
        private DateTime? birthday;
        private Nullable<DateTime> lastLogin;

        // konstruktor (specjalna metoda 
        // uruchamiania podczas tworzenia instancji)
        public Customer()
        {

        }

        public void Print()
        {
            Console.WriteLine($"{firstName} {lastLogin}");

        }
    }
}
