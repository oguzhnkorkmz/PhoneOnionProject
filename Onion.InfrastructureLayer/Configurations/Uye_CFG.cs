using Microsoft.AspNetCore.Identity;
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
    public class Uye_CFG : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            builder.HasIndex(x => x.UserName);

            builder.Property(x => x.Ad)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(30);

            builder.Property(x => x.SoyAd)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(30);

            builder.Property(x => x.Adres)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(100);
        }
    }
}
