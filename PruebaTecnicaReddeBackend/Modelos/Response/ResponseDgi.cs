using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Response
{
    public class ResponseDgi
    {
        public string nombre { get; set; }
        public string NonmbreoRazonSocial { get; set; }
        public string ActividadEconomica { get; set; }
        public string Categoria { get; set; }
        public string AdministracionLocal { get; set; }
        public string RNC { get; set; }
        public string FormatoDePago { get; set; }
        public bool status { get; set; }
    }
}
