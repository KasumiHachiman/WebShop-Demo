using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class OrderDetailMapper : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapper()
        {
            this.ToTable("OrderDetails");

            this.HasKey(e => new { e.OrderID, e.ProductID });
            this.Property(e => e.OrderID).IsRequired();
            this.Property(e => e.ProductID).IsRequired();

            //this.Property(e => e.Quantity).IsRequired();
            //this.HasOptional(e => e.Order).WithMany(e => e.OrderDetails).Map(s => s.MapKey("OrderID")).WillCascadeOnDelete(false);
            //this.HasOptional(e => e.Product).WithMany(e => e.OrderDetails).Map(s => s.MapKey("ProductID")).WillCascadeOnDelete(false);
        }
    }
}