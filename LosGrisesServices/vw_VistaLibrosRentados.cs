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
    
    public partial class vw_VistaLibrosRentados
    {
        public int rent_id { get; set; }
        public System.DateTime rent_fec { get; set; }
        public Nullable<System.DateTime> rent_fec_dev { get; set; }
        public int ejem_id { get; set; }
        public int lib_id { get; set; }
        public string lib_nom { get; set; }
        public Nullable<int> aut_id { get; set; }
        public string aut_nom { get; set; }
        public string aut_ape { get; set; }
        public Nullable<int> gen_id { get; set; }
        public string gen_desc { get; set; }
        public int edi_id { get; set; }
        public string edi_nom { get; set; }
    }
}
