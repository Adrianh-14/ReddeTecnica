using Modelos.Models;
using Modelos.Response;
using Servicios.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Services.IServicios
{
    public interface IServicioEmpresas
    {
        public Task<ResponseEmpresa> crearEmpresa(CrearEmpresasDto obj);
        public Task<List<Empresas>> ObtenerEmpresas();
        public Task<ResponseEmpresa> EliminarEmpresa(int Id);
        public Task<ResponseEmpresa> ActualizarEmpresa(ActualizarEmpresaDto obj);
        public Task<Empresas> ObtenerEmpresaId(int Id);
    }
}
