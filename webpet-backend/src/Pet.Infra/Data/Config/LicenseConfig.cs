using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class LicenseConfig : IEntityTypeConfiguration<License> 
    {
        public void Configure(EntityTypeBuilder<License> builder)
        {
            builder.ToTable("License");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.NumberServices).IsRequired();
            builder.Property(x => x.NumberOrders).IsRequired();
        }
    }

}