using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class MenuGroupMapper : EntityTypeConfiguration<MenuGroup>
    {
        public MenuGroupMapper()
        {
            this.ToTable("MenuGroups");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.Name).IsRequired();
            this.Property(e => e.Name).HasMaxLength(256);

            

        }
    }
}