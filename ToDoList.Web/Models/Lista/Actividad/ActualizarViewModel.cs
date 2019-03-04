using System.ComponentModel.DataAnnotations;

namespace ToDoList.Web.Models.Lista.Actividad
{
    public class ActualizarViewModel
    {
        [Required]
        public int idactividad { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "El nombre de la actividad debe tener al menos 6 caracteres y no exceder los 50 caracteres.")]
        public string nombre { get; set; }
        [Required]
        [StringLength(256, MinimumLength = 10, ErrorMessage = "La descripcion de la actividad debe tener al menos 10 caracteres y no exceder los 256 caracteres.")]
        public string descripcion { get; set; }
        //[Required]
        //public int idusuario { get; set; }
        //public bool finalizada { get; set; }
    }
}
