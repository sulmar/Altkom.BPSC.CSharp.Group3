namespace Altkom.BPSC.CSharp.DbFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyConnection")
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Customers)
                .HasForeignKey(e => e.Customer_Id);

            modelBuilder.Entity<Items>()
                .HasMany(e => e.OrderDetails)
                .WithOptional(e => e.Items)
                .HasForeignKey(e => e.Item_Id);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderDetails)
                .WithOptional(e => e.Orders)
                .HasForeignKey(e => e.Order_Id);
        }
    }
}
