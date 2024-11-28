using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioLibro" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioLibro
    {
                [OperationContract]
        LibroDC ConsultarLibro(Int16 strCodigo);

        [OperationContract]
        List<LibroDC> ListarLibro();

        [OperationContract]
        Boolean InsertarLibro(LibroDC objLibro);

        [OperationContract]
        Boolean ActualizarLibro(LibroDC objLibro);


    }

    [DataContract]
    [Serializable]
    public class LibroDC
    {
        [DataMember]
        public Int16 lib_id { get; set; }
        [DataMember]
        public String lib_nom { get; set; }
        [DataMember]
        public Int16 aut_id { get; set; }
        [DataMember]
        public String aut_nom { get; set; }
        [DataMember]
        public String aut_ape { get; set; }
        [DataMember]
        public Int16 gen_id { get; set; }
        [DataMember]
        public String gen_desc { get; set; }
        [DataMember]
        public String lib_edi { get; set; }
        [DataMember]
        public Int16 lib_fec_pub { get; set; }
        [DataMember]
        public Int16 lib_disp_stock { get; set; }
        [DataMember]
        public Int16 edi_id { get; set; }
        [DataMember]
        public String edi_nom { get; set; }
        [DataMember]
        public String lib_user_reg { get; set; }
        [DataMember]
        public DateTime? lib_fec_reg { get; set; }
        [DataMember]
        public String lib_user_mod { get; set; }
        [DataMember]
        public DateTime? lib_fec_mod { get; set; }
        [DataMember]
        public Int16 lib_state { get; set; }
        [DataMember]
        public String Estado { get; set; }
    }

    [DataContract]
    [Serializable]
    public class LibroViewDC
    {
        [DataMember]
        public Int16 lib_id { get; set; }
        [DataMember]
        public String lib_nom { get; set; }
        [DataMember]
        public Int16 aut_id { get; set; }
        [DataMember]
        public String aut_nom { get; set; }
        [DataMember]
        public String aut_ape { get; set; }
        [DataMember]
        public Int16 gen_id { get; set; }
        [DataMember]
        public String gen_desc { get; set; }
        [DataMember]
        public String lib_edi { get; set; }
        [DataMember]
        public Int16 lib_fec_pub { get; set; }
        [DataMember]
        public Int16 lib_disp_stock { get; set; }
        [DataMember]
        public Int16 edi_id { get; set; }
        [DataMember]
        public String edi_nom { get; set; }
        [DataMember]
        public String lib_user_reg { get; set; }
        [DataMember]
        public DateTime? lib_fec_reg { get; set; }
        [DataMember]
        public String lib_user_mod { get; set; }
        [DataMember]
        public DateTime? lib_fec_mod { get; set; }
        [DataMember]
        public Int16 lib_state { get; set; }
        [DataMember]
        public String Estado { get; set; }
    }
}