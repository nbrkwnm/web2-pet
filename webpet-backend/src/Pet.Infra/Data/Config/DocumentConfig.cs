using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class DocumentConfig : IEntityTypeConfiguration<Document> 
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("Document");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Number).IsRequired();
            builder.HasOne(x => x.Person).WithMany(x => x.Documents);//.HasForeignKey(x => x.PersonId);
        }
    }

}