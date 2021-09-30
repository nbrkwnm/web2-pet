using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class OrderItemConfig : IEntityTypeConfiguration<OrderItem> 
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItem");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Product);//.HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Service);//.HasForeignKey(x => x.ServiceId);
            builder.HasOne(x => x.PriceList);//.HasForeignKey(x => x.PriceList);
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.SoldPrice).IsRequired();
            builder.HasOne(x => x.Order).WithMany(x => x.Items);//.HasForeignKey(x => x.OrderId);
        }
    }

}