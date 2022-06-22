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
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "381fcb71-afe5-4f38-8642-f8bbb8d6e4dd",
                    Email = "gregorduartemartinez@gmail.com",
                    NormalizedEmail = "gregorduartemartinez@gmail.com",
                    Nombre = "Gregor",
                    Apellidos = "Duarte",
                    UserName = "GDuarte",
                    NormalizedUserName = "GDuarte",
                    PasswordHash = hasher.HashPassword(null, "Greg576/"),
                    EmailConfirmed = true
                },
                     new ApplicationUser
                     {
                         Id = "1956f8e9-567a-4748-8981-fd0a62def354",
                         Email = "gabrielduarte77@gmail.com",
                         NormalizedEmail = "gabrielduarte77@gmail.com",
                         Nombre = "Juan",
                         Apellidos = "Perez",
                         UserName = "Jperez",
                         NormalizedUserName = "Jperez",
                         PasswordHash = hasher.HashPassword(null, "Greg576/"),
                         EmailConfirmed = true
                     }
                );
        }
    }
}
