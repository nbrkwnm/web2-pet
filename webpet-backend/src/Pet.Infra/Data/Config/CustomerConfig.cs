using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class CustomerConfig : IEntityTypeConfiguration<Customer> 
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");

            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Person);//.HasForeignKey(x => x.PersonId);
        }
    }

}