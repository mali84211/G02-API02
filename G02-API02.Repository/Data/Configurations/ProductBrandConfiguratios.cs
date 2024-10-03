using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G02_API02.Repository.Data.Configurations
{
    public class ProductBrandConfiguratios : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.property(P => P.Name).IsRequired();
        }
    }
}
