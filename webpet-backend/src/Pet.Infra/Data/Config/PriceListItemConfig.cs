using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class PriceListItemConfig : IEntityTypeConfiguration<PriceListItem> 
    {
        public void Configure(EntityTypeBuilder<PriceListItem> builder)
        {
            builder.ToTable("PriceListItem");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Value).IsRequired();
            builder.HasOne(x => x.Product);//.HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.PriceList).WithMany(x => x.Items);//.HasForeignKey(x => x.PriceListId);
        }
    }

}