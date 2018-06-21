using Altkom.BPSC.CSharp.IServices;
using Altkom.BPSC.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.DbServices
{
    public class DbCustomersService : ICustomersService
    {
        private readonly MyContext context;

        public DbCustomersService()
        {
            context = new MyContext();
        }

        public void Add(Customer customer)
        {
            context.Customers.Add(customer);

            context.SaveChanges();
        }

        public List<Customer> Get()
        {

            //List<Customer> result = new List<Customer>();

            //foreach (Customer customer in context.Customers)
            //{
            //    if (!customer.IsDeleted)
            //    {
            //        result.Add(customer);
            //    }
            //}

            //return result;

            context.Database.Log += Console.WriteLine;

         //   context.Database.ExecuteSqlCommand("dbo.uspCalculate ...");

         //   var customers = context.Database.SqlQuery<Customer>("select * from dbo.Customers").ToList();

            //var query2 = context.Customers
            //    .GroupBy(c => new { c.FirstName, c.LastName })
            //    .Select(g => new { Person = g.Key.FirstName, Qty = g.Count()})
            //    .ToList();

            return context.Customers
                .Where(bla => !bla.IsDeleted)
                .OrderBy(customer => customer.FirstName)
                .ToList();

            //var query1 = from customer in context.Customers
            //             where !customer.IsDeleted
            //             orderby customer.FirstName
            //             select new { customer.FirstName, customer.LastName } ;
        }

        public List<Customer> Get(CustomerSearchCriteria criteria)
        {
            var customers = context.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(criteria.FirstName))
            { 
                customers = customers.Where(c => c.FirstName == criteria.FirstName);
            }

            if (!string.IsNullOrEmpty(criteria.LastName))
            {
                customers = customers.Where(c => c.LastName == criteria.LastName);
            }

            return customers.ToList();

        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
