using System;
using System.Collections.Generic;

namespace DataAcces.Models
{
    public partial class Producto
    {
        public decimal Idproducto { get; set; }
        public decimal? Idcategoria { get; set; }
        public decimal? Idsubcategoria { get; set; }
        public decimal? Idcaracteristica { get; set; }
        public decimal? Idclasificacion { get; set; }
        public decimal? Idtemporada { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
    }
}
