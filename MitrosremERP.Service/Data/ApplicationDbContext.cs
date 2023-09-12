using Microsoft.EntityFrameworkCore;
using MitrosremERP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Aplication.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Zaposleni> Zaposleni { get; set; }
        public DbSet<Ugovor> Ugovori { get; set; }
        public DbSet<Bolovanje> Bolovanja { get; set; }
        public DbSet<GodisnjiOdmor> GodisnjiOdmori { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Zaposleni>().HasData(
                new Zaposleni { Id = 1, Ime = "Aleksandar", Prezime = "Hadzic", Grad = "Sr.Mitrovica", Adresa = "Stari Sor", JMBG = 1702986890023, Mobilni = "0605574477" },
                new Zaposleni { Id = 2, Ime = "Petar", Prezime = "Petrovic", Grad = "Sid", Adresa = "BB", JMBG = 4302386890023, Mobilni = "06553427" },
                new Zaposleni { Id = 3, Ime = "Jovan", Prezime = "Jovanovic", Grad = "Sabac", Adresa = "BB", JMBG = 2132986890023, Mobilni = "0605574477" },
                new Zaposleni { Id = 4, Ime = "Sreten", Prezime = "Sretenovic", Grad = "Beograd", Adresa = "BB", JMBG = 3123986890023, Mobilni = "0605574477" }
                );

            modelBuilder.Entity<Ugovor>().HasData(
                new Ugovor { Id = 1, BrojUgovora = "MS0001", TipUgovora ="Odredjeno", DatumPocetka = new DateOnly(1992, 2, 17),BrojDanaGodisnjeg = 22, ZaposleniId = 1}
                );
        }
    }

  
        
}
