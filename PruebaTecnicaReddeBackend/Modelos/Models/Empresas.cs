using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Modelos.Models
{
    public class Empresas
    {
        
        public int Id { get; set; }
        public string Rnc { get; set; }
        public string Nombre { get; set; }
        public string NombreComercial { get; set; }
        public string Categoria { get; set; }
        public string EsquemaPagos { get; set; }
        public string ActividadEconomica { get; set; }
        public string RamaGubernamental { get; set; }
        public string Estado { get; set; }

    }
    /*Id int primary key identity(1,1),
Rnc varchar(11),
Nombre varchar (40),
NombreComercial varchar(60),
Categoria varchar(60),
EsquemaPagos varchar(100),
ActividadEconomica varchar(120),
RamaGubernamental varchar(120),
Estado varchar(20)*/
}
