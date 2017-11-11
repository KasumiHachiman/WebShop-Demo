using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class ProductTagMapper : EntityTypeConfiguration<ProductTag>
    {
        public ProductTagMapper()
        {
            this.ToTable("ProductTags");
            this.HasKey(e => new { e.ProductID, e.TagID });
            this.Property(e => e.ProductID).IsRequired();
            this.Property(e => e.TagID).IsRequired();

            //this.HasOptional(e => e.Product).WithMany(e => e.ProductTags).Map(s => s.MapKey("ProductID")).WillCascadeOnDelete(false);
            //this.HasOptional(e => e.Tag).WithMany(e => e.ProductTags).Map(c => c.MapKey("TagID")).WillCascadeOnDelete(false);

        }
    }
}