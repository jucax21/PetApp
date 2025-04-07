using Microsoft.AspNetCore.Identity;

namespace PetApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Puedes agregar propiedades extra si quieres, como:
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
    }
}
