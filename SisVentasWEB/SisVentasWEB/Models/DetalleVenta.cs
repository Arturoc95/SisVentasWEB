//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SisVentasWEB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdDetalleIngreso { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Descuento { get; set; }
    
        public virtual DetalleIngreso DetalleIngreso { get; set; }
        public virtual Venta Venta { get; set; }
    }
}