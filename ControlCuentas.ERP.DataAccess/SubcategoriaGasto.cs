//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlCuentas.ERP.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubcategoriaGasto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubcategoriaGasto()
        {
            this.Gasto = new HashSet<Gasto>();
        }
    
        public int IdSubcategoria { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
    
        public virtual CategoriaGasto CategoriaGasto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gasto> Gasto { get; set; }
    }
}
