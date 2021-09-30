using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class AccommodationConfig : IEntityTypeConfiguration<Accommodation> 
    {
        public void Configure(EntityTypeBuilder<Accommodation> builder)
        {
            builder.ToTable("Accommodation");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Ambient);//.HasForeignKey(x => x.AmbientId);
            builder.HasOne(x => x.Occupant);//.HasForeignKey(x => x.OccupantId);
            builder.Property(x => x.EntryDate).IsRequired();
            builder.Property(x => x.ExitDate).IsRequired();
            builder.HasOne(x => x.Service);
        }
    }

}