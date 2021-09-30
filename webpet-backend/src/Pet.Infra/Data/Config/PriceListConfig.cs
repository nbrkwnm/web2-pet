using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class PriceListConfig : IEntityTypeConfiguration<PriceList> 
    {
        public void Configure(EntityTypeBuilder<PriceList> builder)
        {
            builder.ToTable("PriceList");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired();
        }
    }

}