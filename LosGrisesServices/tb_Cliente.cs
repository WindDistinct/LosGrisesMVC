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
    
    public partial class tb_Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Cliente()
        {
            this.tb_Renta = new HashSet<tb_Renta>();
        }
    
        public int cli_id { get; set; }
        public string cli_nom { get; set; }
        public string cli_ape { get; set; }
        public string cli_dir { get; set; }
        public string cli_tel { get; set; }
        public string cli_mail { get; set; }
        public string cli_dni { get; set; }
        public string ubg_id { get; set; }
        public Nullable<System.DateTime> cli_fec_nac { get; set; }
        public string cli_sex { get; set; }
        public byte[] cli_foto { get; set; }
        public string cli_user_reg { get; set; }
        public Nullable<System.DateTime> cli_fec_reg { get; set; }
        public string cli_user_mod { get; set; }
        public Nullable<System.DateTime> cli_fec_mod { get; set; }
        public Nullable<bool> cli_state { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Renta> tb_Renta { get; set; }
        public virtual tb_Ubigeo tb_Ubigeo { get; set; }
    }
}
