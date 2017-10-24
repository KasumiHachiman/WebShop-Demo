using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    internal class ProductMapper : EntityTypeConfiguration<Product>
    {
        public ProductMapper()
        {
            this.ToTable("Products");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.Alias).IsRequired();
            this.Property(e => e.Alias).HasMaxLength(256);
            this.Property(e => e.Alias).HasColumnType("varchar");

            this.Property(e => e.Content).HasMaxLength(500);
            this.Property(e => e.CreatedBy).HasMaxLength(256);
            this.Property(e => e.CreatedDate).IsOptional();
            this.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            this.Property(e => e.Description).HasMaxLength(500);

            this.Property(e => e.Image).HasMaxLength(256);
            this.Property(e => e.MetaDescription).HasMaxLength(500);
            this.Property(e => e.MetaKeyword).HasMaxLength(256);
            this.Property(e => e.MoreImages).HasColumnType("xml");

            this.Property(e => e.Name).IsRequired();
            this.Property(e => e.Name).HasMaxLength(256);

            this.Property(e => e.UpdatedBy).HasMaxLength(256);
            this.Property(e => e.UpdatedDate).IsOptional();
            this.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");

            this.HasRequired(c => c.ProductCategory).WithMany(e=>e.Products).Map(s => s.MapKey("CategoryID"));
        }
    }
}