using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class AmbientConfig : IEntityTypeConfiguration<Ambient> 
    {
        public void Configure(EntityTypeBuilder<Ambient> builder)
        {
            builder.ToTable("Ambient");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.IsOccupied).IsRequired();
        }
    }

}