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
    
    public partial class tb_Genero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Genero()
        {
            this.tb_Libro = new HashSet<tb_Libro>();
        }
    
        public int gen_id { get; set; }
        public string gen_desc { get; set; }
        public string gen_user_reg { get; set; }
        public Nullable<System.DateTime> gen_fec_reg { get; set; }
        public string gen_user_mod { get; set; }
        public Nullable<System.DateTime> gen_fec_mod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Libro> tb_Libro { get; set; }
    }
}
