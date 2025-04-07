using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetApp.Models
{
    public class Mascota
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Raza { get; set; }

        [Required]
        public int Edad { get; set; }

        // Relación con Usuario
        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public ApplicationUser Usuario { get; set; }  // Propiedad de navegación
    }
}
