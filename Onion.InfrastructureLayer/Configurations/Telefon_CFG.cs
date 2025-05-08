using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.InfrastructureLayer.Configurations
{
    public class Telefon_CFG : BaseConfiguration<Telefon>, IEntityTypeConfiguration<Telefon>
    {
        public void Configure(EntityTypeBuilder<Telefon> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Aciklama)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(300);
                   

            builder.Property(x => x.Resim)
                   .HasColumnType("varchar")
                   .HasMaxLength(100)
                   .HasDefaultValue("telefon.png");

            builder.Property(x => x.Stok)
                   .HasColumnType("smallint")
                   .HasDefaultValue(0);

            builder.Property(x => x.Fiyat)
                  .HasColumnType("money");
        }
    }
}
