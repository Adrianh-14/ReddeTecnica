using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Models;
using Servicios.Dtos;
using Servicios.Services.IServicios;
using System.Threading.Tasks;

namespace PruebaTecnicaRedde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresasControllers : ControllerBase
    {
        private readonly IServicioEmpresas servicio;
        public EmpresasControllers(IServicioEmpresas service)
        {
            this.servicio = service;
        }

        [HttpPost("AgregarEmpresas")]
        public async Task<IActionResult> add(CrearEmpresasDto obj) 
        { 
                
            return Ok(await servicio.crearEmpresa(obj));
        
        }

        [HttpPut("Actualizar")]
        public async Task<IActionResult> Update(ActualizarEmpresaDto obj)
        {

            return Ok(await servicio.ActualizarEmpresa(obj));

        }

        [HttpGet("Obtener")]
        public async Task<IActionResult> Get(int Id)
        {

            return Ok(await servicio.ObtenerEmpresaId(Id));

        }

        [HttpDelete("Elminar")]
        public async Task<IActionResult> eliminar(int Id)
        {

            return Ok(await servicio.EliminarEmpresa(Id));

        }

        [HttpGet("ObtenerEmpresas")]
        public async Task<IActionResult> ObtnerAllempresas()
        {

            return Ok(await servicio.ObtenerEmpresas());

        }

    }
}
