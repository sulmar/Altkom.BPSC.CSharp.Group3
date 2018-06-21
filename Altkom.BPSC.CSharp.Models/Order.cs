using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.BPSC.CSharp.Models
{
    public class Order : Base
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime CreateDate { get; private set; }
        public DateTime? DeliveryDate { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> Details { get; set; }

        public Order(Customer customer)
        {
            this.Details = new List<OrderDetail>();

            CreateDate = DateTime.Now;

            this.Customer = customer;
        }

        public void AddDetail(OrderDetail detail)
        {
            this.Details.Add(detail);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{OrderNumber} {CreateDate}");
            sb.AppendLine("---------------------");

            foreach (OrderDetail detail in Details)
            {
                sb.AppendLine(detail.ToString());
            }

            return sb.ToString();
        }
    }
}
