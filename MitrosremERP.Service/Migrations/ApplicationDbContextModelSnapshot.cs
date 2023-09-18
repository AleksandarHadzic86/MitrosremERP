﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MitrosremERP.Aplication.Data;

#nullable disable

namespace MitrosremERP.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.7.23375.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Bolovanje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BrojDanaBolovanja")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateOnly>("PocetakBolovanja")
                        .HasColumnType("date");

                    b.Property<string>("StatusBolovanja")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly?>("ZakljucenoBolovanje")
                        .HasColumnType("date");

                    b.Property<int>("ZaposleniId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("Bolovanja");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.GodisnjiOdmor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrojDanaGodisnjeg")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateOnly>("PocetakGodisnjegOdmora")
                        .HasColumnType("date");

                    b.Property<string>("StatusGodisnjeg")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ZaposleniId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("ZavrsetakGodisnjegOdmora")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("GodisnjiOdmori");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.StepenStrucneSpreme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StepenObrazovanja")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("StepenStrucneSpreme");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StepenObrazovanja = "I Stepen - Osnovno Obrazovanje."
                        },
                        new
                        {
                            Id = 2,
                            StepenObrazovanja = "II Stepen - Strucno osposobljavanje u trajanju do 1 godine."
                        },
                        new
                        {
                            Id = 3,
                            StepenObrazovanja = "III Stepen - Srednje strucno obrazovanje 3 godine."
                        },
                        new
                        {
                            Id = 4,
                            StepenObrazovanja = "IV Stepen - Srednje strucno obrazovanje 4 godine."
                        },
                        new
                        {
                            Id = 5,
                            StepenObrazovanja = "VI-1 Stepen - Osnovne strukovne studije."
                        },
                        new
                        {
                            Id = 6,
                            StepenObrazovanja = "VI-2 Stepen - Osnovne akademske i Specijalisticke strukovne studije."
                        },
                        new
                        {
                            Id = 7,
                            StepenObrazovanja = "VII-1 Stepen - Master akademske i master strukovne studije"
                        },
                        new
                        {
                            Id = 8,
                            StepenObrazovanja = "VIII Stepen - Doktorske studije"
                        });
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Ugovor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrojDanaGodisnjeg")
                        .HasColumnType("int");

                    b.Property<string>("BrojUgovora")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("DatumPocetka")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DatumZavrsetka")
                        .HasColumnType("date");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipUgovora")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ZaposleniId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("Ugovori");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrojDanaGodisnjeg = 22,
                            BrojUgovora = "MS0001",
                            DatumPocetka = new DateOnly(1992, 2, 17),
                            TipUgovora = "Odredjeno",
                            ZaposleniId = 1
                        });
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Zaposleni", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Fiksni")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("JMBG")
                        .HasColumnType("bigint");

                    b.Property<string>("Mobilni")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pol")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Profesija")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RadnoMesto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StepenStrucneSpremeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StepenStrucneSpremeId");

                    b.ToTable("Zaposleni");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adresa = "Stari Sor",
                            Grad = "Sr.Mitrovica",
                            ImageUrl = "",
                            Ime = "Aleksandar",
                            JMBG = 1702986890023L,
                            Mobilni = "0605574477",
                            Pol = "Musko",
                            Prezime = "Hadzic",
                            Profesija = "Elektro Tehnicar",
                            RadnoMesto = "Odrzavanje el.instalacija",
                            StepenStrucneSpremeId = 4
                        },
                        new
                        {
                            Id = 2,
                            Adresa = "BB",
                            Grad = "Sid",
                            ImageUrl = "",
                            Ime = "Petar",
                            JMBG = 4302386890023L,
                            Mobilni = "06553427",
                            Pol = "Musko",
                            Prezime = "Petrovic",
                            Profesija = "Masinski Tehnicar",
                            RadnoMesto = "Odrzavanje masicna",
                            StepenStrucneSpremeId = 4
                        },
                        new
                        {
                            Id = 3,
                            Adresa = "BB",
                            Grad = "Sabac",
                            ImageUrl = "",
                            Ime = "Jovan",
                            JMBG = 2132986890023L,
                            Mobilni = "0605574477",
                            Pol = "Musko",
                            Prezime = "Jovanovic",
                            Profesija = "Diplomirani Tehnolog",
                            RadnoMesto = "Tehnolog hrane",
                            StepenStrucneSpremeId = 6
                        },
                        new
                        {
                            Id = 4,
                            Adresa = "BB",
                            Grad = "Beograd",
                            ImageUrl = "",
                            Ime = "Sreten",
                            JMBG = 3123986890023L,
                            Mobilni = "0605574477",
                            Pol = "Musko",
                            Prezime = "Sretenovic",
                            Profesija = "System Administrator",
                            RadnoMesto = "IT Administrator",
                            StepenStrucneSpremeId = 5
                        },
                        new
                        {
                            Id = 5,
                            Adresa = "Stari Sor",
                            Grad = "Sr.Mitrovica",
                            ImageUrl = "",
                            Ime = "Goran",
                            JMBG = 1702986890023L,
                            Mobilni = "0605574477",
                            Pol = "Musko",
                            Prezime = "Goranic",
                            Profesija = "Developer",
                            RadnoMesto = "Programer",
                            StepenStrucneSpremeId = 5
                        },
                        new
                        {
                            Id = 6,
                            Adresa = "BB",
                            Grad = "Sid",
                            ImageUrl = "",
                            Ime = "MIlan",
                            JMBG = 4302386890023L,
                            Mobilni = "06553427",
                            Pol = "Musko",
                            Prezime = "Milanovic",
                            Profesija = "Master Ekonomista",
                            RadnoMesto = "Finansije",
                            StepenStrucneSpremeId = 7
                        },
                        new
                        {
                            Id = 7,
                            Adresa = "BB",
                            Grad = "Sabac",
                            ImageUrl = "",
                            Ime = "Zoran",
                            JMBG = 2132986890023L,
                            Mobilni = "0605574477",
                            Pol = "Musko",
                            Prezime = "Zoranovic",
                            Profesija = "Diplomirani Ekonomista",
                            RadnoMesto = "Racunovodstvo",
                            StepenStrucneSpremeId = 6
                        },
                        new
                        {
                            Id = 8,
                            Adresa = "BB",
                            Grad = "Beograd",
                            ImageUrl = "",
                            Ime = "Stevan",
                            JMBG = 3123986890023L,
                            Mobilni = "0605574477",
                            Pol = "Musko",
                            Prezime = "Stevanovic",
                            Profesija = "Trgovac",
                            RadnoMesto = "Maloprodaja",
                            StepenStrucneSpremeId = 3
                        });
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Bolovanje", b =>
                {
                    b.HasOne("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Zaposleni", "Zaposleni")
                        .WithMany("Bolovanja")
                        .HasForeignKey("ZaposleniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zaposleni");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.GodisnjiOdmor", b =>
                {
                    b.HasOne("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Zaposleni", "Zaposleni")
                        .WithMany("GodisnjiOdmori")
                        .HasForeignKey("ZaposleniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zaposleni");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Ugovor", b =>
                {
                    b.HasOne("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Zaposleni", "Zaposleni")
                        .WithMany("Ugovori")
                        .HasForeignKey("ZaposleniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zaposleni");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Zaposleni", b =>
                {
                    b.HasOne("MitrosremERP.Domain.Models.ZaposleniMitrosrem.StepenStrucneSpreme", "StepenStrucneSpreme")
                        .WithMany("Zaposleni")
                        .HasForeignKey("StepenStrucneSpremeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StepenStrucneSpreme");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.StepenStrucneSpreme", b =>
                {
                    b.Navigation("Zaposleni");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Zaposleni", b =>
                {
                    b.Navigation("Bolovanja");

                    b.Navigation("GodisnjiOdmori");

                    b.Navigation("Ugovori");
                });
#pragma warning restore 612, 618
        }
    }
}
