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
                            Id = new Guid("e900c613-bad4-4cbf-b52d-808e53f2bce3"),
                            BrojDanaGodisnjeg = 22,
                            BrojUgovora = "MS0001",
                            DatumPocetka = new DateOnly(1992, 2, 17),
                            TipUgovora = "Odredjeno",
                            ZaposleniId = new Guid("bcfb8487-66cd-4307-800e-1ab94c56ed3b")
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
                            Id = new Guid("bcfb8487-66cd-4307-800e-1ab94c56ed3b"),
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
                            Id = new Guid("a12fa17d-b87c-42a1-9624-5027d0db6a77"),
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
                            Id = new Guid("0c61c2ca-5937-46ff-9a7a-bb71a3d8f133"),
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
                            Id = new Guid("f1907408-f085-415d-833c-8d696d0873e9"),
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
                            Id = new Guid("88ccd1bf-9143-4ac5-bae5-23b6cbe914fd"),
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
                            Id = new Guid("ed814e2c-f63d-48f5-8c14-900ce1820640"),
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
                            Id = new Guid("5ad54ba7-29e9-4c08-8af2-0ccc00d577e3"),
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
                            Id = new Guid("f522f9f5-0b93-430d-9af4-232ca761c6b6"),
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
