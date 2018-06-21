using Altkom.BPSC.CSharp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.BPSC.CSharp.DbServices.Configurations
{
    class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            ToTable("Kontrahenci");

            Property(p => p.FirstName)
                .HasMaxLength(40)
                .HasColumnName("Imie");

            Property(p => p.LastName)
                .HasMaxLength(40)
                .HasColumnName("Nazwisko");

        }
    }
}
