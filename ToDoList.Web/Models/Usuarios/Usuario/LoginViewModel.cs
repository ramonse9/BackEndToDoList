using System.ComponentModel.DataAnnotations;

namespace ToDoList.Web.Models.Usuarios.Usuario
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}
