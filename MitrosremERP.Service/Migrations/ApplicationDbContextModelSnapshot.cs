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
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.IdentityModel.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AdresaKorisnik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("GradKorisnik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImeKorisnik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MobilniKorisnik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("PrezimeKorisnik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Bolovanje", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BrojDanaBolovanja")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumPocetkaBolovanja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumZavrsetkaBolovanja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusBolGod")
                        .HasColumnType("int");

                    b.Property<Guid>("ZaposleniId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("Bolovanja");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.DokumentiZaposleni", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImeDokumenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PutanjaDokumenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ZaposleniId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("DokumentiZaposleni");
                });

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.GodisnjiOdmor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojDanaGodisnjeg")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumPocetkaGodisnjeg")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumZavrsetkaGodisnjeg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusBolGod")
                        .HasColumnType("int");

                    b.Property<Guid>("ZaposleniId")
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<DateTime>("DatumPocetka")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumZavrsetka")
                        .HasColumnType("datetime2");

                    b.Property<string>("Napomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoviUgovora")
                        .HasColumnType("int");

                    b.Property<Guid>("ZaposleniId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ZaposleniId");

                    b.ToTable("Ugovori");
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

                    b.Property<int>("PolOsobe")
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

                    b.HasIndex("StepenStrucneSpremeId");

                    b.ToTable("Zaposleni");

                    b.HasData(
                        new
                        {
                            Id = new Guid("356c2c2c-3c3b-4bbc-8105-326887af48dc"),
                            Adresa = "Stari Sor",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sr.Mitrovica",
                            ImageUrl = "",
                            Ime = "Aleksandar",
                            JMBG = "1702986890023",
                            Mobilni = "0605574477",
                            PolOsobe = 0,
                            Prezime = "Hadzic",
                            Profesija = "Elektro Tehnicar",
                            RadnoMesto = "Odrzavanje el.instalacija",
                            StepenStrucneSpremeId = 4
                        },
                        new
                        {
                            Id = new Guid("7d2a18fe-92a1-4230-867f-01440f08d116"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sid",
                            ImageUrl = "",
                            Ime = "Petar",
                            JMBG = "4302386890023",
                            Mobilni = "06553427",
                            PolOsobe = 0,
                            Prezime = "Petrovic",
                            Profesija = "Masinski Tehnicar",
                            RadnoMesto = "Odrzavanje masicna",
                            StepenStrucneSpremeId = 4
                        },
                        new
                        {
                            Id = new Guid("ed5ded49-939c-4608-8683-cd6280b7193c"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sabac",
                            ImageUrl = "",
                            Ime = "Jovan",
                            JMBG = "2132986890023",
                            Mobilni = "0605574477",
                            PolOsobe = 1,
                            Prezime = "Jovanovic",
                            Profesija = "Diplomirani Tehnolog",
                            RadnoMesto = "Tehnolog hrane",
                            StepenStrucneSpremeId = 6
                        },
                        new
                        {
                            Id = new Guid("16b54ea0-a894-402f-9e29-67fa372cd265"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Beograd",
                            ImageUrl = "",
                            Ime = "Sreten",
                            JMBG = "3123986890023",
                            Mobilni = "0605574477",
                            PolOsobe = 0,
                            Prezime = "Sretenovic",
                            Profesija = "System Administrator",
                            RadnoMesto = "IT Administrator",
                            StepenStrucneSpremeId = 5
                        },
                        new
                        {
                            Id = new Guid("7b997e50-29ee-46e2-b3e6-89a221cf67df"),
                            Adresa = "Stari Sor",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sr.Mitrovica",
                            ImageUrl = "",
                            Ime = "Goran",
                            JMBG = "1702986890023",
                            Mobilni = "0605574477",
                            PolOsobe = 0,
                            Prezime = "Goranic",
                            Profesija = "Developer",
                            RadnoMesto = "Programer",
                            StepenStrucneSpremeId = 5
                        },
                        new
                        {
                            Id = new Guid("4c63fe62-26d1-468e-a036-edc64948cf04"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sid",
                            ImageUrl = "",
                            Ime = "MIlan",
                            JMBG = "4302386890023",
                            Mobilni = "06553427",
                            PolOsobe = 0,
                            Prezime = "Milanovic",
                            Profesija = "Master Ekonomista",
                            RadnoMesto = "Finansije",
                            StepenStrucneSpremeId = 7
                        },
                        new
                        {
                            Id = new Guid("cef58994-c1c1-49dd-9e27-5e1eb3511b92"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Sabac",
                            ImageUrl = "",
                            Ime = "Zorana",
                            JMBG = "2132986890023",
                            Mobilni = "0605574477",
                            PolOsobe = 1,
                            Prezime = "Zoranovic",
                            Profesija = "Diplomirani Ekonomista",
                            RadnoMesto = "Racunovodstvo",
                            StepenStrucneSpremeId = 6
                        },
                        new
                        {
                            Id = new Guid("868eb7b6-2ff4-4de5-8ad1-1aac3c5c21fc"),
                            Adresa = "BB",
                            DatumRodjenja = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mitrosrem@ad.rs",
                            Grad = "Beograd",
                            ImageUrl = "",
                            Ime = "Stevan",
                            JMBG = "3123986890023",
                            Mobilni = "0605574477",
                            PolOsobe = 0,
                            Prezime = "Stevanovic",
                            Profesija = "Trgovac",
                            RadnoMesto = "Maloprodaja",
                            StepenStrucneSpremeId = 6
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MitrosremERP.Domain.Models.IdentityModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MitrosremERP.Domain.Models.IdentityModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MitrosremERP.Domain.Models.IdentityModel.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MitrosremERP.Domain.Models.IdentityModel.ApplicationUser", null)
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

            modelBuilder.Entity("MitrosremERP.Domain.Models.ZaposleniMitrosrem.DokumentiZaposleni", b =>
                {
                    b.HasOne("MitrosremERP.Domain.Models.ZaposleniMitrosrem.Zaposleni", "Zaposleni")
                        .WithMany("DokumentiZaposleni")
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

                    b.Navigation("DokumentiZaposleni");

                    b.Navigation("GodisnjiOdmori");

                    b.Navigation("Ugovori");
                });
#pragma warning restore 612, 618
        }
    }
}
