using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class HospitalizationEventConfig : IEntityTypeConfiguration<Hospitalization> 
    {
        public void Configure(EntityTypeBuilder<Hospitalization> builder)
        {
            builder.ToTable("Hospitalization");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).IsRequired();
            builder.HasOne(x => x.Order);//.HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Accommodation);
        }
    }

}