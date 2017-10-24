using System.Data.Entity.ModelConfiguration;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    internal class VisitorStatisticMapper : EntityTypeConfiguration<VisitorStatistic>
    {
        public VisitorStatisticMapper()
        {
            this.ToTable("VisitorStatistics");
            this.HasKey(e => e.ID);
            //this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.IPAddress).HasMaxLength(456);

            this.Property(e => e.VisitedDate).IsOptional();
            this.Property(e => e.VisitedDate).HasColumnType("smalldatetime");
        }
    }
}