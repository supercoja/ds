﻿using System.Data.Entity.ModelConfiguration;
using DevStore.Domain;

namespace DevStore.DataContext.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");

            HasKey(k => k.Id);
            Property(x => x.Title).HasMaxLength(160).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.AcquireDate).IsRequired();

            HasRequired(x => x.Category);

        }
    }
}
