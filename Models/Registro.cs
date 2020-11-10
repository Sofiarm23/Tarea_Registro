using System.ComponentModel.DataAnnotations;

namespace Tarea_Registro.Models
{
    public class Registro
    {
        [Required]
        [Display(Name="Nombre:")]
        public string nombre { get; set; }

        [Required]
        [Display(Name="Precio:")]
        public double precio { get; set; }

        [Required]
        [Display(Name="Descripción:")]
        public string descripcion { get; set; }
    }
}