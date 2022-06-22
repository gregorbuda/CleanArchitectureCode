using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CleanArchitectureIdentity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
new IdentityUserRole<string>
{
    RoleId = "c0227d0d-3a86-45ff-add7-67bdcc3fe056",
    UserId = "381fcb71-afe5-4f38-8642-f8bbb8d6e4dd"
},
new IdentityUserRole<string>
{
    RoleId = "7f357cf0-68ee-4ed1-a337-1b169b0870a9",
    UserId = "1956f8e9-567a-4748-8981-fd0a62def354"
}
);
        }
    }
}

