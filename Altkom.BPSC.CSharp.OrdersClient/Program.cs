using Altkom.BPSC.CSharp.DbServices;
using Altkom.BPSC.CSharp.IServices;
using Altkom.BPSC.CSharp.MockServices;
using Altkom.BPSC.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Altkom.BPSC.CSharp.OrdersClient
{
    class Program
    {
        static void Main(string[] args)
        {

            AddCustomerTest();

            VariableTest();

            CreateOrderTest();    

           // ReferenceTest();
        }

        private static void AddCustomerTest()
        {
            var customer1 = new Customer("Marcin", "Sulecki");
            var customer2 = new Customer("Bartek", "Sulecki");

            // ICustomersService customersService = new MockCustomersService();

            ICustomersService customersService = new DbCustomersService();

            customersService.Add(customer1);
            customersService.Add(customer2);

            List<Customer> customers = customersService.Get();

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }



        }

        private static void VariableTest()
        {
            int number = 200;

            number++;

            var customer = new Customer("Marcin", "Sulecki");

            var pair = new
            {
                LeftCustomer = customer,
                RightCustomer = customer
            };

            Console.WriteLine(number);
        }


        private static void CreateOrderTest()
        {

            Order order = new Order(new Customer("Marcin", "Sulecki"))
            {
                OrderNumber = "ZAM 001/2018"
            };

            Product product1 = new Product("C# krok po kroku", 100);
            OrderDetail detail1 = new OrderDetail(product1, 2);
            order.AddDetail(detail1);

            Product product2 = new Product(".NET Framework 4.5", 50);
            order.AddDetail(new OrderDetail(product2, 10));

            Service service1 = new Service("Usługa programistyczna", 1000, TimeSpan.Parse("3:25") + TimeSpan.FromMinutes(10));

            order.AddDetail(new OrderDetail(service1, 3));

            Console.WriteLine(order);

            Sender<Order> sender = new Sender<Order>();
            Order lastOrder = sender.GetLastItem();

            Sender<Customer> sender2 = new Sender<Customer>();
            sender2.Send(order.Customer);
            Customer lastCustomer = sender2.GetLastItem();

            //Customer customer = (Customer) sender.GetLastItem();

            //Sender<int> sender3 = new Sender<int>();
            //sender3.Send(100);

            Printer printer = new Printer();

            printer.Print(order);

            printer.Print(DateTime.Now);

            printer.Print(100);

            printer.Print<Product>(product1);

            


        }

        private static decimal Calculate(Order order)
        {
            decimal totalAmount;

            throw new NotImplementedException();
            
        }

        private static void Print(ref int x)
        {
            x++;
        }

       

        private static void Print(Order order)
        {
            order.DeliveryDate = DateTime.Now;
        }

        private static void Print(string message)
        {
            message  = message + "!";
        }

        static void ReferenceTest()
        {
            string message = "Hello";

            Print(message);

            if (true)
            {
                int x = 10;
                Print(ref x);
            }

            Order order = new Order(new Customer("Marcin", "Sulecki"))
            {
                OrderNumber = "ZAM 001/2018"
            };

            Print(order);


            Console.WriteLine(order.Customer.FirstName);

        }
    }
}
