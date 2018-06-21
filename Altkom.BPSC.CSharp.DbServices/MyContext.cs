using Altkom.BPSC.CSharp.DbServices.Configurations;
using Altkom.BPSC.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.DbServices
{
    public class MyContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public MyContext()
            : base("MyConnection")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Fluent Api

            //modelBuilder.Entity<Customer>()
            //    .HasKey(p => p.Id)
            //    .ToTable("Kontrahenci");

            //modelBuilder.Entity<Customer>()
            //    .Property(p => p.FirstName)
            //        .HasMaxLength(40)
            //        .HasColumnName("Imie");

            //modelBuilder.Entity<Customer>()
            //    .Property(p => p.LastName)
            //        .HasMaxLength(40)
            //        .HasColumnName("Nazwisko")
            //    ;

            //modelBuilder.Entity<Item>()
            //    .Property(p => p.Name)
            //        .HasMaxLength(100)
            //    ;

            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ItemConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
