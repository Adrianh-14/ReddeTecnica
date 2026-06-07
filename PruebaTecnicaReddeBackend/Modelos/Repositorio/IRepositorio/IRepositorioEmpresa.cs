using Modelos.Context;
using Modelos.Models;
using Modelos.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Repositorio.IRepositorio
{
    public interface IRepositorioEmpresa
    {
        public Task<ResponseEmpresa> crearEmpresa(Empresas obj);
        public Task<List<Empresas>> ObtenerEmpresas();
        public Task<ResponseEmpresa> EliminarEmpresa(int Id);
        public Task<ResponseEmpresa> ActualizarEmpresa(Empresas obj);
        public Task<Empresas> ObtenerEmpresaId(int Id);

    }
}
