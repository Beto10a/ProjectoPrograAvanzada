//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEBAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOrdenes
    {
        public long ConOrdenes { get; set; }
        public long ConUsuario { get; set; }
        public long ConProductos { get; set; }
        public Nullable<System.DateTime> DiaOrden { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Canton { get; set; }
        public string CodigoPostal { get; set; }
        public long ConEstadoOrden { get; set; }
    
        public virtual TEstadoOrden TEstadoOrden { get; set; }
        public virtual TProductos TProductos { get; set; }
        public virtual TUsuario TUsuario { get; set; }
    }
}