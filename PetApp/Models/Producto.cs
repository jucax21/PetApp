using System.ComponentModel.DataAnnotations;

namespace PetApp.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        [Range(0.01, 100000)]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }

        public int Stock { get; set; }
    }
}
