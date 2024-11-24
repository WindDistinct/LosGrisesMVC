using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioCliente" in both code and config file together.
    [ServiceContract]
    public interface IServicioCliente
    {
        [OperationContract]
        ClienteDC ConsultarCliente(Int16 strCodigo);

        [OperationContract]
        List<ClienteDC> ListarCliente();

        [OperationContract]
        Boolean InsertarCliente(ClienteDC objCliente);

        [OperationContract]
        Boolean ActualizarCliente(ClienteDC objCliente);


    }

    [DataContract]
    [Serializable]
    public class ClienteDC
    {
        [DataMember]
        public Int16 cli_id { get; set; }
        [DataMember]
        public String cli_nom { get; set; }
        [DataMember]
        public String cli_ape { get; set; }
        [DataMember]
        public String cli_dir { get; set; }
        [DataMember]
        public String cli_tel { get; set; }
        [DataMember]
        public String cli_mail { get; set; }
        [DataMember]
        public String cli_dni { get; set; }
        [DataMember]
        public String ubg_id {  get; set; }
        [DataMember]
        public String Region { get; set; }
        [DataMember]
        public String Provincia { get; set; }
        [DataMember]
        public String Distrito { get; set; }
        [DataMember]
        public DateTime cli_fec_nac {  get; set; }
        [DataMember]
        public String cli_sex {  get; set; }
        [DataMember]
        public Byte[] cli_foto { get; set; }
        [DataMember]
        public String cli_user_reg {  get; set; }
        [DataMember]
        public DateTime? cli_fec_reg { get; set; }
        [DataMember]
        public String cli_user_mod { get; set; }
        [DataMember]
        public DateTime? cli_fec_mod { get; set; }
        [DataMember]
        public Int16 cli_state { get; set; }
        [DataMember]
        public String Estado {  get; set; }


    }
}
