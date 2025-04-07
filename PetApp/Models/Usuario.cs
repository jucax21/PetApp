using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PetApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Correo { get; set; } = string.Empty;

        [Required]
        public string Contrasena { get; set; } = string.Empty;

        [Required]
        public string Rol { get; set; } = "Cliente";

        public List<Mascota> Mascotas { get; set; } = new();
    }
}
