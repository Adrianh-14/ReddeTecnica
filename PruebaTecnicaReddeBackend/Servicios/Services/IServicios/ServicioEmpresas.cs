using Modelos.Models;
using Modelos.Repositorio.IRepositorio;
using Modelos.Response;
using Servicios.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Services.IServicios
{
    public class ServicioEmpresas : IServicioEmpresas
    {
        private readonly IRepositorioEmpresa repositorioEmpresa;
        public ServicioEmpresas(IRepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioEmpresa = repositorioEmpresa;
        }

        public Task<ResponseEmpresa> ActualizarEmpresa(ActualizarEmpresaDto obj)
        {
            var datos = new Empresas() {
             Id = obj.Id,
             Nombre = obj.Nombre,
             NombreComercial = obj.NombreComercial,
             Categoria = obj.Categoria,
             EsquemaPagos = obj.EsquemaPagos,
             ActividadEconomica = obj.ActividadEconomica,
             RamaGubernamental = obj.RamaGubernamental            
            };

            /*
             
              public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreComercial { get; set; }
        public string Categoria { get; set; }
        public string EsquemaPagos { get; set; }
        public string ActividadEconomica { get; set; }
        public string RamaGubernamental { get; set; }
             
             */
            return repositorioEmpresa.ActualizarEmpresa(datos);
        }

        public Task<ResponseEmpresa> crearEmpresa(CrearEmpresasDto obj)
        {

            var datos = new Empresas()
            {
                Rnc =obj.Rnc,
                Nombre = obj.Nombre,
                NombreComercial = obj.NombreComercial,
                Categoria = obj.Categoria,
                EsquemaPagos = obj.EsquemaPagos,
                ActividadEconomica = obj.ActividadEconomica,
                RamaGubernamental = obj.RamaGubernamental,
                Estado = obj.Estado
            };
            return repositorioEmpresa.crearEmpresa(datos);
        }

        public Task<ResponseEmpresa> EliminarEmpresa(int Id)
        {
            return repositorioEmpresa.EliminarEmpresa(Id);
        }

        public Task<Empresas> ObtenerEmpresaId(int Id)
        {
            return repositorioEmpresa.ObtenerEmpresaId(Id);
        }

        public Task<List<Empresas>> ObtenerEmpresas()
        {
            return repositorioEmpresa.ObtenerEmpresas();
        }
    }
}
