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
    public class Model_CFG : BaseConfiguration<Model>, IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ModelAdi).HasColumnType("nvarchar").HasMaxLength(50);

          
        }
    }
}
