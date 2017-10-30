using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class OrderMapper : EntityTypeConfiguration<Order>
    {
        public OrderMapper()
        {
            this.ToTable("Orders");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.CustomerName).IsRequired();
            this.Property(e => e.CustomerName).HasMaxLength(256);

            this.Property(e => e.CustomerAddress).IsRequired();
            this.Property(e => e.CustomerAddress).HasMaxLength(356);

            this.Property(e => e.CustomerEmail).HasMaxLength(256);
            this.Property(e => e.CustomerMobile).HasMaxLength(256);
            this.Property(e => e.CustomerMessage).HasMaxLength(500);

            this.Property(e => e.CreatedDate).IsOptional();
            this.Property(e => e.CreatedDate).HasColumnType("smalldatetime");

            this.Property(e => e.CreatedBy).HasMaxLength(256);
            this.Property(e => e.PaymentMethod).HasMaxLength(256);
            this.Property(e => e.PaymentStatus).HasMaxLength(100);
        }
    }
}