using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class FooterMapper : EntityTypeConfiguration<Footer>
    {
        public FooterMapper()
        {
            this.ToTable("Footers");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.Content).IsRequired();
            this.Property(e => e.Content).HasMaxLength(500);
        }
    }
}