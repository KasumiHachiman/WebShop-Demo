using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class SlideMapper : EntityTypeConfiguration<Slide>
    {
        public SlideMapper()
        {
            this.ToTable("Slides");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.Description).HasMaxLength(500);
            this.Property(e => e.Image).HasMaxLength(256);
            this.Property(e => e.Name).IsRequired();
            this.Property(e => e.Name).HasMaxLength(256);
            this.Property(e => e.URL).HasMaxLength(256);
        }
    }
}