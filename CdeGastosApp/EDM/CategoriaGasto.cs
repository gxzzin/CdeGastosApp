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
    
    public partial class CategoriaGasto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategoriaGasto()
        {
            this.CategoriaGastoHijas = new HashSet<CategoriaGasto>();
            this.Gastos = new HashSet<Gasto>();
        }
    
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> CategoriaGastoPadreId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategoriaGasto> CategoriaGastoHijas { get; set; }
        public virtual CategoriaGasto CategoriaGastoPadre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}
