﻿using eShopSolution.Data.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new { x.CategoryId, x.ProductId });

            builder.ToTable("ProductInCategories");

            builder.HasOne(x => x.Product)
                   .WithMany(y => y.ProductInCategories)
                   .HasForeignKey(x => x.ProductId);

            builder.HasOne(x => x.Category)
                   .WithMany(y => y.ProductInCategories)
                   .HasForeignKey(x => x.CategoryId);
        }
    }
}