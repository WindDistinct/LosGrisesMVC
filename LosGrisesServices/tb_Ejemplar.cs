//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LosGrisesServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Ejemplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Ejemplar()
        {
            this.tb_Renta = new HashSet<tb_Renta>();
        }
    
        public int ejem_id { get; set; }
        public int lib_id { get; set; }
        public bool ejem_disp { get; set; }
        public string ejem_condicion { get; set; }
        public Nullable<int> alm_id { get; set; }
        public string ejem_user_reg { get; set; }
        public System.DateTime ejem_fec_reg { get; set; }
        public string ejem_user_mod { get; set; }
        public Nullable<System.DateTime> ejem_fec_mod { get; set; }
    
        public virtual tb_Almacen tb_Almacen { get; set; }
        public virtual tb_Libro tb_Libro { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Renta> tb_Renta { get; set; }
    }
}