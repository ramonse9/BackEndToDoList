using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Entidades.Usuarios;

namespace ToDoList.Datos.Mapping.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {            
            builder.ToTable("Usuario")
                .HasKey(u => u.idusuario);
        }
    }
}
