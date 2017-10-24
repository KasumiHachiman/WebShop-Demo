using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    internal class MenuMapper : EntityTypeConfiguration<Menu>
    {
        public MenuMapper()
        {
            this.ToTable("Menus");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.Name).IsRequired();
            this.Property(e => e.Name).HasMaxLength(256);

            this.Property(e => e.URL).IsRequired();
            this.Property(e => e.URL).HasMaxLength(256);

            this.Property(e => e.GroupID).IsRequired();
            this.Property(e => e.Target).HasMaxLength(10);

            this.Property(e => e.Status).IsRequired();

            //this.HasOptional(e => e.MenuGroup).WithMany(e => e.Menus).Map(e => e.MapKey("GroupID")).WillCascadeOnDelete(false);
            this.HasRequired(e => e.MenuGroup).WithMany().Map(e => e.MapKey("GroupID"));
        }
    }
}