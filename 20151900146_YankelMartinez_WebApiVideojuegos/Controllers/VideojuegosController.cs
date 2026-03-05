using _20151900146_YankelMartinez_WebApiVideojuegos.Entities;
using _20251900146_YankelMartinez_WebApiVideojuegos.Features.Videojuegos;
using Microsoft.AspNetCore.Mvc;

namespace _20251900146_YankelMartinez_WebApiVideojuegos.Controllers
{
    [Route("api/VideojuegosController")]
    [ApiController]
    public class VideojuegosController : ControllerBase
    {
        private readonly VideojuegosAppService videojuegosAppService;

        public VideojuegosController(VideojuegosAppService videojuegosAppService)
        {
            this.videojuegosAppService = videojuegosAppService;
        }

        // GET: Obtener todos los videojuegos
        [HttpGet("ListarVideojuegos")]
        public IActionResult ObtenerVideojuegos()
        {
            List<Videojuego> videojuegos = videojuegosAppService.ObtenerVideojuegos();
            return Ok(videojuegos);
        }

        // GET: Obtener videojuego por ID
        [HttpGet]
        [Route("ObtenerVideojuegoPorId/{id}")]
        public IActionResult ObtenerVideojuegoPorId([FromRoute] int id)
        {
            return Ok(videojuegosAppService.ObtenerVideojuegoPorId(id));
        }

        // POST: Agregar nuevo videojuego
        [HttpPost]
        [Route("AgregarVideojuego")]
        public IActionResult GuardarVideojuego([FromBody] Videojuego videojuego)
        {
            videojuegosAppService.GuardarVideojuego(videojuego);
            return Ok("Videojuego agregado exitosamente.");
        }

        // PUT: Actualizar videojuego existente
        [HttpPut]
        [Route("ActualizarVideojuego")]
        public IActionResult ActualizarVideojuego([FromBody] Videojuego videojuego)
        {
            videojuegosAppService.ActualizarVideojuego(videojuego);
            return Ok("Videojuego actualizado exitosamente.");
        }

        // DELETE: Eliminar videojuego
        [HttpDelete]
        [Route("EliminarVideojuego/{id}")]
        public IActionResult EliminarVideojuego([FromRoute] int id)
        {
            videojuegosAppService.EliminarVideojuego(id);
            return Ok("Videojuego eliminado exitosamente.");
        }
    }
}