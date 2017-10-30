using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class PostCategoryMapper : EntityTypeConfiguration<PostCategory>
    {
        public PostCategoryMapper()
        {
            this.ToTable("PostCategories");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.Name).HasMaxLength(256);
            this.Property(e => e.Name).IsRequired();

            this.Property(e => e.Alias).HasMaxLength(256);
            this.Property(e => e.Alias).IsRequired();
            //this.Property(e => e.Alias).IsUnicode(false);
            this.Property(e => e.Alias).HasColumnType("varchar");

            this.Property(e => e.Description).HasMaxLength(500);
            this.Property(e => e.Image).HasMaxLength(500);
            this.Property(e => e.MetaDescription).HasMaxLength(500);
            this.Property(e => e.MetaKeyword).HasMaxLength(500);
            //this.Property(e => e.ParentID).HasMaxLength(200);
            this.Property(e => e.UpdatedBy).HasMaxLength(256);

            this.Property(e => e.UpdatedDate).IsOptional();
            this.Property(e => e.UpdatedDate).HasColumnType("smalldatetime");
        }
    }
}