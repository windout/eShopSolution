using eShopSolution.Data.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.ModelConfiguration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();


            builder.HasOne(x => x.Product).WithMany(y => y.Carts).HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.AppUser).WithMany(y => y.Carts).HasForeignKey(x => x.UserId);

        }
    }
}
