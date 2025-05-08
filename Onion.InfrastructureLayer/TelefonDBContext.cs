using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Onion.CoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Onion.InfrastructureLayer
{
    public class TelefonDBContext : IdentityDbContext<Uye, Rol, int>
    {

        public TelefonDBContext()
        {
        }
        public TelefonDBContext(DbContextOptions options) : base(options)
        {
        }



        public DbSet<Telefon> Telefonlar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Model> Modeller { get; set; }
        public DbSet<Sepet> Sepetler { get; set; }

        public DbSet<IsletimSistemi> IsletimSistemleri { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = TelefonOnionDB; Integrated Security = True; Trust Server Certificate = True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> { UserId = 1, RoleId = 1 });


            modelBuilder.Entity<Uye>().HasData(
                new Uye
                {
                    Id = 1,
                    Ad = "Super",
                    SoyAd = "User",
                    Adres = "host",
                    Email = "super@deneme.com",
                    NormalizedEmail = "SUPER@DENEME.COM",
                    UserName = "sprUser",
                    NormalizedUserName = "SPRUSER",
                    ConcurrencyStamp = "45bb2efe-6055-41f5-a159-31b73801539c",
                    SecurityStamp = "7f14965c-6dcc-4120-ad4a-0391d43eaa5e",
                    EmailConfirmed = false
                }
            );

            modelBuilder.Entity<Rol>().HasData(
                new Rol { Id = 1, Name = "Admin", NormalizedName = "ADMİN", ConcurrencyStamp = "198c8793-5b7b-4b42-bcb2-0dfc332545c6" },
                new Rol { Id = 2, Name = "Uye", NormalizedName = "UYE", ConcurrencyStamp = "eb7f818b-046a-406a-9179-375bc2407396" }
            );

            modelBuilder.Entity<Marka>().HasData(
                new Marka { MarkaID = 1, MarkaAdi = "Iphone", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Marka { MarkaID = 2, MarkaAdi = "Samsung", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Marka { MarkaID = 3, MarkaAdi = "Huawei", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Marka { MarkaID = 4, MarkaAdi = "Nothing", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme }
            );

            modelBuilder.Entity<Model>().HasData(
                new Model { ModelID = 1, MarkaID = 1, ModelAdi = "Iphone16", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Model { ModelID = 2, MarkaID = 1, ModelAdi = "Iphone16 Pro", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Model { ModelID = 3, MarkaID = 1, ModelAdi = "Iphone15", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Model { ModelID = 4, MarkaID = 2, ModelAdi = "S24", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Model { ModelID = 5, MarkaID = 2, ModelAdi = "S24 Ultra", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Model { ModelID = 6, MarkaID = 3, ModelAdi = "Mate", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Model { ModelID = 7, MarkaID = 3, ModelAdi = "GR3", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Model { ModelID = 8, MarkaID = 4, ModelAdi = "Phone (2A) Plus", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new Model { ModelID = 9, MarkaID = 4, ModelAdi = "Phone (1)", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme }
            );

            modelBuilder.Entity<IsletimSistemi>().HasData(
                new IsletimSistemi { IsletimSistemiID = 1, IsletimSistemiAdi = "IOS", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new IsletimSistemi { IsletimSistemiID = 2, IsletimSistemiAdi = "Android", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme },
                new IsletimSistemi { IsletimSistemiID = 3, IsletimSistemiAdi = "HarmonyOS", EklenmeTarihi = new DateTime(2024, 1, 1), KayitDurumu = CoreLayer.Enums.KayitDurumu.KayitEkleme }
            );

        }

    }
}
