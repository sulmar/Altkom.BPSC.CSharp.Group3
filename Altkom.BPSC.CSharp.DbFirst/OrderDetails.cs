namespace Altkom.BPSC.CSharp.DbFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetails
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public int? Item_Id { get; set; }

        public int? Order_Id { get; set; }

        public virtual Items Items { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
