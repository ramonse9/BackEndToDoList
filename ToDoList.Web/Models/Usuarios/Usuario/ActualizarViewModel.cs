using System.ComponentModel.DataAnnotations;

namespace ToDoList.Web.Models.Usuarios.Usuario
{
    public class ActualizarViewModel
    {
        [Required]
        public int idusuario { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "El nombre debe tener al menos 6 caracteres y no exceder los 50 caracteres.")]
        public string nombre { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }

        public bool actualizarpassword { get; set; }

    }
}
