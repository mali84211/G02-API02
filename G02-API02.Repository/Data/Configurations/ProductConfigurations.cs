using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G02_API02.Repository.Data.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(P => P.Name).HasMaxLength(200);
            builder.property(P => P.PictureUrl).IsRequired(true);
            builder.property(P => P.Price).HasColumnType("decimal(18,2)");
            builder.HasOne(P => P.Brand)
                .WithMany()
                .HasForeignKey(P => P.BrandId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(P => P.Type)
               .WithMany()
               .HasForeignKey(P => P.TypeId)
               .OnDelete(DeleteBehavior.SetNull);
            builder.property(P => P.BrandId).IsRequired(false);
            builder.property(P => P.TypeID).IsRequired(false);
        }
    }
}
