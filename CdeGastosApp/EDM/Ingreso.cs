//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CdeGastosApp.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingreso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal MontoIngreso { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string Moneda { get; set; }
        public decimal TipoCambio { get; set; }
        public int CuentaId { get; set; }
        public int Estado { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
    }
}