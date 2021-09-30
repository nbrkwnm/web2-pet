using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class CashRegisterConfig : IEntityTypeConfiguration<CashRegister> 
    {
        public void Configure(EntityTypeBuilder<CashRegister> builder)
        {
            builder.ToTable("CashRegister");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).IsRequired();
            builder.Property(x => x.IsOpen).IsRequired();
            builder.HasOne(x => x.User);//.HasForeignKey(x => x.UserId);
        }
    }

}