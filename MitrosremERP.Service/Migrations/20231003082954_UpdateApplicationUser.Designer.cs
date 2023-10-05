﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MitrosremERP.Aplication.Data;

#nullable disable

namespace MitrosremERP.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231003082954_UpdateApplicationUser")]
    partial class UpdateApplicationUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("ApplicationUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Bolovanje", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BrojDanaBolovanja")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("PocetakBolovanja")
                        .HasColumnType("date");

                    b.Property<string>("StatusBolovanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly?>("ZakljucenoBolovanje")
                        .HasColumnType("date");

                    b.Property<Guid>("ZaposleniId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("Bolovanja");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.GodisnjiOdmor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojDanaGodisnjeg")
                        .HasColumnType("int");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("PocetakGodisnjegOdmora")
                        .HasColumnType("date");

                    b.Property<string>("StatusGodisnjeg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ZaposleniId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("ZavrsetakGodisnjegOdmora")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("GodisnjiOdmori");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Pol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PolOsobe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pol");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PolOsobe = "Musko"
                        },
                        new
                        {
                            Id = 2,
                            PolOsobe = "Zensko"
                        });
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.StepenStrucneSpreme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("StepenObrazovanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojDanaGodisnjeg")
                        .HasColumnType("int");

                    b.Property<string>("BrojUgovora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("DatumPocetka")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("DatumZavrsetka")
                        .HasColumnType("date");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipUgovora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ZaposleniId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("Ugovori");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9514e9dd-022e-4f67-baee-44232eda19cc"),
                            BrojDanaGodisnjeg = 22,
                            BrojUgovora = "MS0001",
                            DatumPocetka = new DateOnly(1992, 2, 17),
                            TipUgovora = "Odredjeno",
                            ZaposleniId = new Guid("bf8b7780-9d7c-4270-a560-73a92ea9e9ac")
                        });
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Zaposleni", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fiksni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobilni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PolOsobeId")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profesija")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RadnoMesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StepenStrucneSpremeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PolOsobeId");

                    b.HasIndex("StepenStrucneSpremeId");

                    b.ToTable("Zaposleni");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf8b7780-9d7c-4270-a560-73a92ea9e9ac"),
                            Adresa = "Stari Sor",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sr.Mitrovica",
                            ImageUrl = "",
                            Ime = "Aleksandar",
                            JMBG = "1702986890023",
                            Mobilni = "0605574477",
                            PolOsobeId = 1,
                            Prezime = "Hadzic",
                            Profesija = "Elektro Tehnicar",
                            RadnoMesto = "Odrzavanje el.instalacija",
                            StepenStrucneSpremeId = 4
                        },
                        new
                        {
                            Id = new Guid("83778dd4-4042-4cb3-8893-a6df3a3ef990"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sid",
                            ImageUrl = "",
                            Ime = "Petar",
                            JMBG = "4302386890023",
                            Mobilni = "06553427",
                            PolOsobeId = 1,
                            Prezime = "Petrovic",
                            Profesija = "Masinski Tehnicar",
                            RadnoMesto = "Odrzavanje masicna",
                            StepenStrucneSpremeId = 4
                        },
                        new
                        {
                            Id = new Guid("fb9d50d8-19a4-48d7-a2f3-14c2600f6b41"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sabac",
                            ImageUrl = "",
                            Ime = "Jovan",
                            JMBG = "2132986890023",
                            Mobilni = "0605574477",
                            PolOsobeId = 2,
                            Prezime = "Jovanovic",
                            Profesija = "Diplomirani Tehnolog",
                            RadnoMesto = "Tehnolog hrane",
                            StepenStrucneSpremeId = 6
                        },
                        new
                        {
                            Id = new Guid("c872f60b-7a00-4b84-a415-d08d2fcc2f8a"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Beograd",
                            ImageUrl = "",
                            Ime = "Sreten",
                            JMBG = "3123986890023",
                            Mobilni = "0605574477",
                            PolOsobeId = 1,
                            Prezime = "Sretenovic",
                            Profesija = "System Administrator",
                            RadnoMesto = "IT Administrator",
                            StepenStrucneSpremeId = 5
                        },
                        new
                        {
                            Id = new Guid("2da988f4-a1e3-4d95-b162-c9fcc9daa0a6"),
                            Adresa = "Stari Sor",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sr.Mitrovica",
                            ImageUrl = "",
                            Ime = "Goran",
                            JMBG = "1702986890023",
                            Mobilni = "0605574477",
                            PolOsobeId = 1,
                            Prezime = "Goranic",
                            Profesija = "Developer",
                            RadnoMesto = "Programer",
                            StepenStrucneSpremeId = 5
                        },
                        new
                        {
                            Id = new Guid("d90e0a17-4f94-407e-aa56-2c2cf0c22c69"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sid",
                            ImageUrl = "",
                            Ime = "MIlan",
                            JMBG = "4302386890023",
                            Mobilni = "06553427",
                            PolOsobeId = 1,
                            Prezime = "Milanovic",
                            Profesija = "Master Ekonomista",
                            RadnoMesto = "Finansije",
                            StepenStrucneSpremeId = 7
                        },
                        new
                        {
                            Id = new Guid("b2427545-3bf2-4571-a718-37cd9ddb836e"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sabac",
                            ImageUrl = "",
                            Ime = "Zorana",
                            JMBG = "2132986890023",
                            Mobilni = "0605574477",
                            PolOsobeId = 2,
                            Prezime = "Zoranovic",
                            Profesija = "Diplomirani Ekonomista",
                            RadnoMesto = "Racunovodstvo",
                            StepenStrucneSpremeId = 6
                        },
                        new
                        {
                            Id = new Guid("f1941c6b-16c8-480f-b2cd-71c6c91ad5b1"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Beograd",
                            ImageUrl = "",
                            Ime = "Stevan",
                            JMBG = "3123986890023",
                            Mobilni = "0605574477",
                            PolOsobeId = 1,
                            Prezime = "Stevanovic",
                            Profesija = "Trgovac",
                            RadnoMesto = "Maloprodaja",
                            StepenStrucneSpremeId = 6
                        });
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.IdentityModel.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.ApplicationUser");

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobilni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.ApplicationUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Pol", "PolOsobe")
                        .WithMany("Zaposleni")
                        .HasForeignKey("PolOsobeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MitrosremERP.Domain.Models.ZaposleniMitrosrem.StepenStrucneSpreme", "StepenStrucneSpreme")
                        .WithMany("Zaposleni")
                        .HasForeignKey("StepenStrucneSpremeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PolOsobe");

                    b.Navigation("StepenStrucneSpreme");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Pol", b =>
                {
                    b.Navigation("Zaposleni");
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
