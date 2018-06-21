using Altkom.BPSC.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.OrdersClient
{
    class Printer
    {
        private bool IsOn;

        //public void Print(Order order)
        //{
        //    Console.WriteLine(order);
        //}

        //public void Print(Product product)
        //{
        //    Console.WriteLine(product);
        //}


        public void Print<TItem>(TItem item)
        {
            Console.WriteLine(item);
        }
    }
}
