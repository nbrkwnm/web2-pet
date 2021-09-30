using System;
using Pet.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pet.Infrastructure.Data 
{
    
    public class CashRegisterEventConfig : IEntityTypeConfiguration<CashRegisterEvent> 
    {
        public void Configure(EntityTypeBuilder<CashRegisterEvent> builder)
        {
            builder.ToTable("CashRegisterEvent");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Date).IsRequired();
            builder.HasOne(x => x.CashRegister).WithMany(x => x.Events);//.HasForeignKey(x => x.CashRegisterId);
        }
    }

}