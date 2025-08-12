﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductsMangementSystem.Data.EntityConfigrations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Price)
                   .HasPrecision(18, 2)
                   .IsRequired();

            builder.Property(p => p.CreationDate)
                   .IsRequired();

            builder.Property(p => p.StartDate)
                   .IsRequired();

            builder.Property(p => p.Duration)
                   .IsRequired();

            builder.HasQueryFilter(p => !p.IsDeleted);

            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
