using System;
using Pet.Domain.Models;
using Pet.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class AnimalConfig : IEntityTypeConfiguration<Animal> 
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animal");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.BirthDate).IsRequired();
            builder.HasOne(x => x.Customer).WithMany(x => x.Pets);//.HasForeignKey(x => x.CustomerId);
        }
    }

}