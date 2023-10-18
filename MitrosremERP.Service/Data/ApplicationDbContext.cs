using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MitrosremERP.Domain.Enum;
using MitrosremERP.Domain.Models.IdentityModel;
using MitrosremERP.Domain.Models.ZaposleniMitrosrem;
using MitrosremERP.Infrastructure.Data;
using MitrosremERP.Infrastructure.DbInitilizer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Zaposleni> Zaposleni { get; set; }
        public DbSet<Ugovor> Ugovori { get; set; }
        public DbSet<Bolovanje> Bolovanja { get; set; }
        public DbSet<GodisnjiOdmor> GodisnjiOdmori { get; set; }
        public DbSet<StepenStrucneSpreme> StepenStrucneSpreme { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new RoleSeedConfiguration());
            //modelBuilder.ApplyConfiguration(new UserSeedConfiguration());
            //modelBuilder.ApplyConfiguration(new UserRoleSeedConfiguration());


            Guid zaposleniId1 = Guid.NewGuid();
            Guid zaposleniId2 = Guid.NewGuid();
            Guid zaposleniId3 = Guid.NewGuid();
            Guid zaposleniId4 = Guid.NewGuid();
            Guid zaposleniId5 = Guid.NewGuid();
            Guid zaposleniId6 = Guid.NewGuid();
            Guid zaposleniId7 = Guid.NewGuid();
            Guid zaposleniId8 = Guid.NewGuid();

            modelBuilder.Entity<Zaposleni>().HasData(
                new Zaposleni { Id = zaposleniId1, Ime = "Aleksandar", Prezime = "Hadzic", Grad = "Sr.Mitrovica", Adresa = "Stari Sor", JMBG = "1702986890023", Mobilni = "0605574477", Profesija = "Strukovni inzenjer el. i racunara", StepenStrucneSpremeId = 4, RadnoMesto = "System Administrator", ImageUrl = "", DatumRodjenja = new DateTime(2000, 1, 1), Email = "mitrosrem@ad.rs", PolOsobe = PolOsobe.Musko },
                new Zaposleni { Id = zaposleniId2, Ime = "Petra", Prezime = "Petrovic", Grad = "Sid", Adresa = "BB", JMBG = "4302386890023", Mobilni = "06553427", Profesija = "Masinski Tehnicar", StepenStrucneSpremeId = 4, RadnoMesto = "Odrzavanje masicna", ImageUrl = "", DatumRodjenja = new DateTime(2000, 1, 1), Email = "mitrosrem@ad.rs", PolOsobe = PolOsobe.Zensko },
                new Zaposleni { Id = zaposleniId3, Ime = "Jovan", Prezime = "Jovanovic", Grad = "Sabac", Adresa = "BB", JMBG = "2132986890023", Mobilni = "0605574477", Profesija = "Diplomirani Tehnolog", StepenStrucneSpremeId = 6, RadnoMesto = "Tehnolog hrane", ImageUrl = "", DatumRodjenja = new DateTime(2000, 1, 1), Email = "mitrosrem@ad.rs", PolOsobe = PolOsobe.Zensko },
                new Zaposleni { Id = zaposleniId4, Ime = "Sreten", Prezime = "Sretenovic", Grad = "Beograd", Adresa = "BB", JMBG = "3123986890023", Mobilni = "0605574477", Profesija = "System Administrator", StepenStrucneSpremeId = 5, RadnoMesto = "IT Administrator", ImageUrl = "", DatumRodjenja = new DateTime(2000, 1, 1), Email = "mitrosrem@ad.rs", PolOsobe = PolOsobe.Musko },
                new Zaposleni { Id = zaposleniId5, Ime = "Jelena", Prezime = "Jovanovic", Grad = "Sr.Mitrovica", Adresa = "Stari Sor", JMBG = "1702986890023", Mobilni = "0605574477", Profesija = "Developer", StepenStrucneSpremeId = 5, RadnoMesto = "Programer", ImageUrl = "", DatumRodjenja = new DateTime(2000, 1, 1), Email = "mitrosrem@ad.rs", PolOsobe = PolOsobe.Zensko},
                new Zaposleni { Id = zaposleniId6, Ime = "MIlan", Prezime = "Milanovic", Grad = "Sid", Adresa = "BB", JMBG = "4302386890023", Mobilni = "06553427", Profesija = "Master Ekonomista", StepenStrucneSpremeId = 7, RadnoMesto = "Finansije", ImageUrl = "", DatumRodjenja = new DateTime(2000, 1, 1), Email = "mitrosrem@ad.rs", PolOsobe = PolOsobe.Musko },
                new Zaposleni { Id = zaposleniId7, Ime = "Zorana", Prezime = "Zoranovic", Grad = "Sabac", Adresa = "BB", JMBG = "2132986890023", Mobilni = "0605574477", Profesija = "Diplomirani Ekonomista", StepenStrucneSpremeId = 6, RadnoMesto = "Racunovodstvo", ImageUrl = "", DatumRodjenja = new DateTime(2000, 1, 1), Email = "mitrosrem@ad.rs", PolOsobe = PolOsobe.Zensko },
                new Zaposleni { Id = zaposleniId8, Ime = "Stevan", Prezime = "Stevanovic", Grad = "Beograd", Adresa = "BB", JMBG = "3123986890023", Mobilni = "0605574477", Profesija = "Trgovac", StepenStrucneSpremeId = 6, RadnoMesto = "Maloprodaja", ImageUrl = "", DatumRodjenja = new DateTime(2000, 1, 1), Email = "mitrosrem@ad.rs", PolOsobe = PolOsobe.Musko }
                );


            modelBuilder.Entity<StepenStrucneSpreme>().HasData(
                   new StepenStrucneSpreme { Id = 1, StepenObrazovanja = "I Stepen - Osnovno Obrazovanje." },
                   new StepenStrucneSpreme { Id = 2, StepenObrazovanja = "II Stepen - Strucno osposobljavanje u trajanju do 1 godine." },
                   new StepenStrucneSpreme { Id = 3, StepenObrazovanja = "III Stepen - Srednje strucno obrazovanje 3 godine." },
                   new StepenStrucneSpreme { Id = 4, StepenObrazovanja = "IV Stepen - Srednje strucno obrazovanje 4 godine." },
                   new StepenStrucneSpreme { Id = 5, StepenObrazovanja = "VI-1 Stepen - Osnovne strukovne studije." },
                   new StepenStrucneSpreme { Id = 6, StepenObrazovanja = "VI-2 Stepen - Osnovne akademske i Specijalisticke strukovne studije." },
                   new StepenStrucneSpreme { Id = 7, StepenObrazovanja = "VII-1 Stepen - Master akademske i master strukovne studije" },
                   new StepenStrucneSpreme { Id = 8, StepenObrazovanja = "VIII Stepen - Doktorske studije" }
                );
        }
    }

  
        
}
