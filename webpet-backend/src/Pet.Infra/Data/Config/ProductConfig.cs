using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class ProductConfig : IEntityTypeConfiguration<Product> 
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.BarCode).IsRequired();
            builder.Property(x => x.UnitCost).IsRequired();
            builder.HasOne(x => x.Inventory).WithMany(x => x.Products);//.HasForeignKey(x => x.InventoryId);
        }
    }

}