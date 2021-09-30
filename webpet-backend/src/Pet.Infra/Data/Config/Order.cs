using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class OrderConfig : IEntityTypeConfiguration<Order> 
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderNumber).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.HasOne(x => x.Payment);//.HasForeignKey(x => x.PaymentId);
        }
    }

}