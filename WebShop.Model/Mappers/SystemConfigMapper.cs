using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    internal class SystemConfigMapper : EntityTypeConfiguration<SystemConfig>
    {
        public SystemConfigMapper()
        {
            this.ToTable("SystemConfigs");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.Code).IsRequired();
            this.Property(e => e.Code).HasMaxLength(256);
            this.Property(e => e.Code).HasColumnType("varchar");
            this.Property(e => e.ValueString).HasMaxLength(256);

        }
    }
}