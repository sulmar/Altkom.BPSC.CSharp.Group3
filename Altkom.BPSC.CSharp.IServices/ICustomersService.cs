using Altkom.BPSC.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.IServices
{
    // Wzorzec projektowy repozytorium
    public interface ICustomersService
    {
        List<Customer> Get();
        void Add(Customer customer);
        void Update(Customer customer);
        void Remove(int id);

        List<Customer> Get(CustomerSearchCriteria criteria);
    }


    public class CustomerSearchCriteria
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
