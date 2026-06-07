using Modelos.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Services.IServicios
{
    public interface IConsultasDGI
    {
        public Task<ResponseDgi> Consultas(string Rnc);
    }
}
