using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoToken.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var listaPaises= new List<string>() { "Colombia", "Peru", "Chile" }; //directamente sin usar una base de datos listo paises por definido 
            return Ok(listaPaises);
        }
    }
}
