using Microsoft.EntityFrameworkCore;
using Modelos.Context;
using Modelos.Models;
using Modelos.Repositorio.IRepositorio;
using Modelos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Repositorio
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {

        private readonly ContextDb contextDb; 
        public RepositorioEmpresa(ContextDb contextDb)
        {
            this.contextDb = contextDb;
        }

        public async Task<ResponseEmpresa> ActualizarEmpresa(Empresas obj)
        {
            try { 
          var datos = await contextDb.Database.ExecuteSqlRawAsync("EXEC Actualizar_Empresa @Id = {0}, @Nombre = {1}, @NombreComercial = {2}, @Categoria = {3}, @EsquemaPagos = {4}, @ActividadEconomica = {5}, @RamaGubernamental = {6}",
                obj.Id,
                obj.Nombre,
                obj.NombreComercial,
                obj.Categoria,
                obj.EsquemaPagos,
                obj.ActividadEconomica,
                obj.RamaGubernamental
                );
                if (datos< 0)
                {
                    return new ResponseEmpresa() {
                        Success = true,
                        Data = datos
                    };
                }
               
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            };

            return new ResponseEmpresa() {
                Success = false,
                Data = 0
            };

        }

        public async Task<ResponseEmpresa> crearEmpresa(Empresas obj)
        {
            try
            {
                var datos = await contextDb.Database.ExecuteSqlRawAsync("EXEC Crear_empresa  @RNC ={0}, @Nombre = {1}, @NombreComercial = {2}, @Categoria = {3}, @EsquemaPagos = {4}, @ActividadEconomica = {5}, @RamaGubernamental = {6}, @Estado = {7}",
            
                      obj.Rnc,
                      obj.Nombre,
                      obj.NombreComercial,
                      obj.Categoria,
                      obj.EsquemaPagos,
                      obj.ActividadEconomica,
                      obj.RamaGubernamental,
                      obj.Estado
                      );
                if (datos<0)
                {
                    return new ResponseEmpresa() { 
                    Success = true,
                    Data = datos
                     
                    };
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            ;

            return new ResponseEmpresa() {
                Success = false,
                Data = 0
            };
        }

        public async Task<ResponseEmpresa> EliminarEmpresa(int Id)
        {
            try
            {
                var datos = await contextDb.Database.ExecuteSqlRawAsync("EXEC Eliminar_Empresas  @Id ={0}",
                     Id
                      );
                if (datos< 0)
                {
                    return new ResponseEmpresa() {
                        Success = true,
                        Data = datos

                    };
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            ;

            return new ResponseEmpresa() {

                Success = false,
                Data = 0
            };
        }

        public async Task<Empresas> ObtenerEmpresaId(int Id)
        {
            try
            {
                var datos = await contextDb.Empresas.FromSqlRaw("EXEC Obtener_Empresa  @Id ={0}",
                     Id
                      ).ToListAsync();

                return datos.FirstOrDefault();
    
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            ;

            return null;
        }

        public async Task<List<Empresas>> ObtenerEmpresas()
        {
            try
            {
                return await contextDb.Empresas.FromSqlRaw("EXEC ObtenerTodas_Empresa"
                  ).ToListAsync();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            ;

            return null;
        }
    }
}
