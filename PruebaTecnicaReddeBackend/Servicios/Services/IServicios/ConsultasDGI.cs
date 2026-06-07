using Modelos.Response;
using Octetus.ConsultasDgii.Services;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Services.IServicios
{
    public class ConsultasDGI : IConsultasDGI
    {
        
       
        public async Task<ResponseDgi> Consultas(string Rnc)
        {
            var datos = new ServicioConsultasWebDgii();
            var consulta =  datos.ConsultarRncContribuyentes(Rnc);
            if (consulta.Success)
            {
                return new ResponseDgi
                {
                    nombre = consulta.NombreComercial,
                    NonmbreoRazonSocial = consulta.NombreORazónSocial,
                    ActividadEconomica = consulta.ActividadEconomica,
                    Categoria = consulta.Categoría,
                    AdministracionLocal = consulta.AdministracionLocal,
                    RNC = consulta.CedulaORnc,
                    status = true,
                    FormatoDePago = consulta.RegimenDePagos
                };

            }
            return null;

            
        }
    }
}
