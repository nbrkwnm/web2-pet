using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class OccupantConfig : IEntityTypeConfiguration<Occupant> 
    {
        public void Configure(EntityTypeBuilder<Occupant> builder)
        {
            builder.ToTable("Occupant");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Animal);//.HasForeignKey(x => x.AnimalId);
        }
    }

}