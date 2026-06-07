using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios.Services.IServicios;
using System.Threading.Tasks;

namespace PruebaTecnicaRedde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasDGI : ControllerBase
    {

        private readonly IConsultasDGI servicio;
        public ConsultasDGI(IConsultasDGI servicio)
        {
           this.servicio = servicio;
        }

        [HttpGet("ObtenerDatos")]
        public async  Task<IActionResult> ObtenerDatos(string Rnc) { 
        

            return Ok(await servicio.Consultas(Rnc));  
        
        }
    }
}
