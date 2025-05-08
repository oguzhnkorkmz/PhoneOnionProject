using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.CoreLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.InfrastructureLayer.Configurations
{
    public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(x => x.EklenmeTarihi).HasColumnType("smalldatetime");
            builder.Property(x => x.GuncellemeTarihi).HasColumnType("smalldatetime");
            builder.Property(x => x.SilmeTarihi).HasColumnType("smalldatetime");
        }
    }
}
