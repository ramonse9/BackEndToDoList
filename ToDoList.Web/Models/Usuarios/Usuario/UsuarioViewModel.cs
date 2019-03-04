using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Web.Models.Usuarios.Usuario
{
    public class UsuarioViewModel
    {
        public int idusuario { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public byte[] passwordhash { get; set; }
    }
}
