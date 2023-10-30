using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MitrosremERP.Domain.Models.IdentityModel;

namespace MitrosremERP.Infrastructure.Data
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "7e78f5df-4f21-41f0-8205-6eca5503f7e4",
                    Name = Roles.Role_SuperAdmin,
                    NormalizedName = Roles.Role_SuperAdmin.ToUpper(),
                }) ;
        }
    }
}
