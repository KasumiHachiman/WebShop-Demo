using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    internal class ErrorMapper : EntityTypeConfiguration<Error>
    {
        public ErrorMapper()
        {
            this.ToTable("Errors");
            this.HasKey(e => e.ID);
            this.Property(e=>e.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e=>e.ID).IsRequired();

            this.Property(e => e.Message).IsRequired();
            this.Property(e => e.Message).HasMaxLength(500);

            //this.Property(e => e.StackTrace).IsRequired();
            this.Property(e => e.StackTrace).HasMaxLength(500);

            this.Property(e => e.CreatedDate).IsOptional();
            this.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
        }
    }
}