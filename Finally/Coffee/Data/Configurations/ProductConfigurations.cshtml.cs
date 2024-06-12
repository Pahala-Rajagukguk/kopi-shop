using Coffee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Coffee.Data
{
    public class ProductConfigurationsModel:IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product>builder)
        {
             builder.Property(p =>p.ImageName).HasColumnName("ImageFileName");
        }
    }   
}
