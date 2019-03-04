using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Entidades.Lista;

namespace ToDoList.Datos.Mapping.Lista
{
    public class ActividadMap : IEntityTypeConfiguration<Actividad>
    {
        public void Configure(EntityTypeBuilder<Actividad> builder)
        {
            builder.ToTable("Actividad")
                 .HasKey(a => a.idactividad);
        }
    }
}
