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
    public class Marka_CFG:BaseConfiguration<Marka>, IEntityTypeConfiguration<Marka>
    {
        public void Configure(EntityTypeBuilder<Marka> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.MarkaAdi)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(20);

           
        }
    }
}
