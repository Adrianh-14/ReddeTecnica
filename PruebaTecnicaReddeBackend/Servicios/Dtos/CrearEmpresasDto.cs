using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios.Dtos
{
    public class CrearEmpresasDto
    {
        public string Rnc { get; set; }
        public string Nombre { get; set; }
        public string NombreComercial { get; set; }
        public string Categoria { get; set; }
        public string EsquemaPagos { get; set; }
        public string ActividadEconomica { get; set; }
        public string RamaGubernamental { get; set; }
        public string Estado { get; set; }
    }
}
