using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Datos;
using ToDoList.Entidades.Lista;
using ToDoList.Web.Models.Lista.Actividad;

namespace ToDoList.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadesController : ControllerBase
    {
        private readonly DbContextToDoList _context;

        public ActividadesController(DbContextToDoList context)
        {
            _context = context;
        }

        // GET: api/Actividades/Listar
        [HttpGet("[action]/{idUsuario}")]
        public async Task<IEnumerable<ActividadViewModel>> Listar([FromRoute] int idUsuario)
        {
            var actividad = await _context.Actividades.Where(a => a.idusuario == idUsuario).ToListAsync();
            
            return actividad.Select(a => new ActividadViewModel
            {
                idactividad = a.idactividad,
                nombre = a.nombre,
                descripcion = a.descripcion,
                idusuario = a.idusuario,                
                finalizada = a.finalizada
            });

        }

        // GET: api/Actividades/Mostrar/5
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> Mostrar([FromRoute] int id)
        {
            var actividad = await _context.Actividades.FindAsync(id);

            if (actividad == null)
            {
                return NotFound();
            }

            return Ok(new Actividad
            {
                idactividad = actividad.idactividad,
                nombre = actividad.nombre,
                descripcion = actividad.descripcion,
                finalizada = actividad.finalizada
            });
        }

        // PUT: api/Actividades/Actualizar/5
        [HttpPut("[action]")]
        public async Task<IActionResult> Actualizar([FromBody] ActualizarViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (model.idactividad <= 0)
            {
                return BadRequest();
            }

            var actividad = await _context.Actividades.FirstOrDefaultAsync(a => a.idactividad == model.idactividad);

            if (actividad == null)
            {
                return NotFound();
            }

            actividad.nombre = model.nombre;
            actividad.descripcion = model.descripcion;
            //actividad.finalizada = model.finalizada;          

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }

            return Ok();
        }

        // POST: api/Actividades/Crear
        [HttpPost("[action]")]
        public async Task<IActionResult> Crear([FromBody] CrearViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Actividad actividad = new Actividad
            {
                nombre = model.nombre,
                descripcion = model.descripcion,
                idusuario = model.idusuario,
                finalizada = false
            };

            _context.Actividades.Add(actividad);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }
            
        // DELETE: api/Actividades/Eliminar/5
        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> Eliminar([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var actividad = await _context.Actividades.FindAsync(id);
            if (actividad == null)
            {
                return NotFound();
            }

            _context.Actividades.Remove(actividad);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(actividad);
        }

        // PUT: api/Actividades/Finalizar/5
        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> Finalizar([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var actividad = await _context.Actividades.FirstOrDefaultAsync(a => a.idactividad == id);

            if (actividad == null)
            {
                return NotFound();
            }

           actividad.finalizada = true;          

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }

            return Ok();
        }

        //PUT: api/Actividades/Pendiente/5
        [HttpPut("[action]/{id}")]
        public async Task<IActionResult> Pendiente([FromRoute] int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var actividad = await _context.Actividades.FirstOrDefaultAsync(a => a.idactividad == id);

            if (actividad == null)
            {
                return NotFound();
            }

            actividad.finalizada = false;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return BadRequest();
            }
            return Ok();
        }

        private bool ActividadExists(int id)
        {
            return _context.Actividades.Any(e => e.idactividad == id);
        }
    }
}