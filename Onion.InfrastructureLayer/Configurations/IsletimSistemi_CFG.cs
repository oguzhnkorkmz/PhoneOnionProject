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
    public class IsletimSistemi_CFG:BaseConfiguration<IsletimSistemi>,IEntityTypeConfiguration<IsletimSistemi>
        /*,IEntityTypeConfiguration<IsletimSistemi>*/
    {
        public void Configure(EntityTypeBuilder<IsletimSistemi> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.IsletimSistemiAdi)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(20);

        }
    }
}
