using CleanArchitectureIdentity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureIdentity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "c0227d0d-3a86-45ff-add7-67bdcc3fe056",
                Name = "administrator",
                NormalizedName = "Administrator"
            },
           new IdentityRole
           {
               Id = "7f357cf0-68ee-4ed1-a337-1b169b0870a9",
               Name = "Operator",
               NormalizedName = "Operator"
           }
            );
        }
    }
}
