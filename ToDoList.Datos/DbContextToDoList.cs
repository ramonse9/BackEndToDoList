using Microsoft.EntityFrameworkCore;
using ToDoList.Datos.Mapping.Lista;
using ToDoList.Datos.Mapping.Usuarios;
using ToDoList.Entidades.Lista;
using ToDoList.Entidades.Usuarios;

namespace ToDoList.Datos
{
    public class DbContextToDoList : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Actividad> Actividades { get; set; }

        public DbContextToDoList(DbContextOptions<DbContextToDoList> options) : base(options)
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new ActividadMap());
        }   
    }
}
