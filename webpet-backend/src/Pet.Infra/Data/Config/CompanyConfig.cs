using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class CompanyConfig : IEntityTypeConfiguration<Company> 
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Document);//.HasForeignKey(x => x.DocumentId);
            builder.Property(x => x.FantasyName);
            builder.Property(x => x.CorporateName);
            builder.HasOne(x => x.License);//.HasForeignKey(x => x.LicenseId);
        }
    }

}