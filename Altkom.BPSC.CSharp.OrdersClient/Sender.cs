using Altkom.BPSC.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.OrdersClient
{
    // Klasa generyczna

    class Sender<TItem>
        where TItem : class
    {
        private TItem last;

        public void Send(TItem item)
        {
            Console.WriteLine($"Sending SMS: {item}");
            last = item;
        }

        public TItem GetLastItem()
        {
            return last;
        }
    }

    class MyDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {
        }
    }


    //class Sender
    //{
    //    private object last;

    //    public void Send(object item)
    //    {
    //        Console.WriteLine($"Sending SMS: {item}");
    //        last = item;
    //    }

    //    public object GetLastItem()
    //    {
    //        return last;
    //    }
    //}

    //class CustomerSender
    //{
    //    private Customer last;

    //    public void Send(Customer customer)
    //    {
    //        Console.WriteLine($"Sending SMS: {customer}");
    //        last = customer;
    //    }

    //    public Customer GetLastOrder()
    //    {
    //        return last;
    //    }
    //}
}
