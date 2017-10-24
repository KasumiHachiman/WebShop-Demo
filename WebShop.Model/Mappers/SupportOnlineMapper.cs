using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Model.Models;

namespace WebShop.Model.Mappers
{
    public class SupportOnlineMapper : EntityTypeConfiguration<SupportOnline>
    {
        public SupportOnlineMapper()
        {
            this.ToTable("SupportOnlines");
            this.HasKey(e => e.ID);
            this.Property(e => e.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.ID).IsRequired();

            this.Property(e => e.Department).HasMaxLength(256);
            this.Property(e => e.Email).HasMaxLength(256);
            this.Property(e => e.Facebook).HasMaxLength(256);
            this.Property(e => e.Mobile).HasMaxLength(20);
            this.Property(e => e.Name).IsRequired();
            this.Property(e => e.Name).HasMaxLength(256);
            this.Property(e => e.Skype).HasMaxLength(256);
            this.Property(e => e.Yahoo).HasMaxLength(256);
        }
    }
}
