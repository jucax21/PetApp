using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PetApp.Models
{
    public enum EstadoCita
    {
        Pendiente,
        Completada,
        Cancelada
    }
    public class Cita
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [Required]
        public int MascotaId { get; set; }

        [ForeignKey("MascotaId")]
        public Mascota Mascota { get; set; }

        [Required]
        public int ServicioId { get; set; }

        [ForeignKey("ServicioId")]
        public Servicio Servicio { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public ApplicationUser Usuario { get; set; }  // Propiedad de navegación

        public bool Completada { get; set; } = false; // Nueva propiedad

        public EstadoCita Estado { get; set; } = EstadoCita.Pendiente;
    }
}
