using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Infrastructure.Data
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "7e78f5df-4f21-41f0-8205-6eca5503f7e4",
                    UserId = "44cd0526-d183-448d-81c9-fdc07ed0e466"
                });
        }
    }
}
