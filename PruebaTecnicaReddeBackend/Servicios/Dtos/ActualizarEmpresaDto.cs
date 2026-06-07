using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios.Dtos
{
    public class ActualizarEmpresaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NombreComercial { get; set; }
        public string Categoria { get; set; }
        public string EsquemaPagos { get; set; }
        public string ActividadEconomica { get; set; }
        public string RamaGubernamental { get; set; }
    }
}
