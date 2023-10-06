using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MitrosremERP.Domain.Models.IdentityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Data
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            //var hasher = new PasswordHasher<ApplicationUser>();
            //builder.HasData(
            //    new ApplicationUser
            //    {
            //        Id = "44cd0526-d183-448d-81c9-fdc07ed0e466",
            //        UserName = "aleksandarhadzic1986@gmail.com",
            //        Email = "aleksandarhadzic1986@gmail.com",
            //        NormalizedEmail = "ALEKSANDARHADZIC1986@GMAIL.COM",
            //        Ime = "Aleksandar",
            //        Prezime = "Hadzic",
            //        Adresa = "Stari Sor 38",
            //        Grad = "Sremska Mitrovica",
            //        Mobilni = "0605574477",
            //        PasswordHash = hasher.HashPassword(null, "Mitrosrem123!")
            //    }) ;
        }
    }
}
