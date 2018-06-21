using Altkom.BPSC.CSharp.DbServices;
using Altkom.BPSC.CSharp.IServices;
using Altkom.BPSC.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.WPFClient.ViewModels
{
    public class CustomersViewModel
    {

        private readonly ICustomersService customersService;

        public List<Customer> Customers { get; set; }


        private Customer customer;

        public Customer SelectedCustomer
        {
            get { return customer; }
            set
            {
                customer = value;


            }
        }


        public CustomersViewModel()
            : this(new DbCustomersService())
        {

        }

        public CustomersViewModel(ICustomersService customersService)
        {
            this.customersService = customersService;

            this.Customers = customersService.Get();
        }
    }
}
