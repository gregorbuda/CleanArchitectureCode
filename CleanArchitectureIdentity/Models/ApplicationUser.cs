using Microsoft.AspNetCore.Identity;


namespace CleanArchitectureIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

    }
}
