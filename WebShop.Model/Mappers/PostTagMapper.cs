using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class PostTagMapper : EntityTypeConfiguration<PostTag>
    {
        public PostTagMapper()
        {
            this.ToTable("PostTags");

            this.HasKey(e => new { e.PostID, e.TagID });
            this.Property(e => e.PostID).IsRequired();
            this.Property(e => e.TagID).IsRequired();

            this.HasOptional(e => e.Post).WithMany(e => e.PostTags).Map(s => s.MapKey("PostID")).WillCascadeOnDelete(false);
            this.HasOptional(e => e.Tag).WithMany(e => e.PostTags).Map(c => c.MapKey("TagID")).WillCascadeOnDelete(false);


        }
    }
}