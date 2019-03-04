using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ToDoList.Entidades.Lista;

namespace ToDoList.Entidades.Usuarios
{
    public class Usuario
    {
        public int idusuario { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "El nombre debe tener al menos 6 caracteres y no exceder los 50 caracteres.")]
        public string nombre { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public byte[] passwordhash { get; set; }
        [Required]
        public byte[] passwordsalt { get; set; }

        public ICollection<Actividad> actividades { get; set; }
    }
}
