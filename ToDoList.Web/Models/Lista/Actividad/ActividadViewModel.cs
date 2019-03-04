using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Web.Models.Lista.Actividad
{
    public class ActividadViewModel
    {
        public int idactividad { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int idusuario { get; set; }
        public bool finalizada { get; set; }
    }
}
