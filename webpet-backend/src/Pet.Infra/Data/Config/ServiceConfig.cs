using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class ServiceConfig : IEntityTypeConfiguration<Service> 
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Service");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.ExecutionTime).IsRequired();
        }
    }

}