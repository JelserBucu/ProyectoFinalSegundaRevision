//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comprension_Lectora.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTOS
    {
        public int CodigoProductosVenta { get; set; }
        public string Nombre_Producto { get; set; }
        public string Efectos { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public string Presentacion { get; set; }
        public Nullable<int> Unidades { get; set; }
        public Nullable<decimal> PrecioDeCompra { get; set; }
        public Nullable<decimal> PrecioDeVenta { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<int> Existencia { get; set; }
    }
}