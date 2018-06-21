using System;

namespace Altkom.BPSC.CSharp.Models
{
    public class OrderDetail : Base
    {
        public OrderDetail(Item item, int quantity)
        {
            Item = item;
            Quantity = quantity;
            UnitPrice = item.UnitPrice;
        }

        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public override string ToString()
        {
            return $"{Item} Qty: {Quantity} {UnitPrice:C2}";

            #region Zła praktyka!

            //if (Item is Product)
            //{
            //    Product product = (Product)Item;

            //    return $"{product.Name} {product.Color} Qty: {Quantity} {UnitPrice:C2}";
            //}
            //else
            //if (Item is Service)
            //{
            //    Service service = (Service)Item;

            //    return $"{service.Name} {service.Duration}  Qty: {Quantity} {UnitPrice:C2}";
            //}

            //else
            //    throw new NotSupportedException();

            #endregion
        }
    }
}
