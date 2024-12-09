using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    [ServiceContract]
    public interface IServicioPersonal
    {
        [OperationContract]
        PersonalDC ConsultarPersonal(Int16 strCodigo);

        [OperationContract]
        List<PersonalDC> ListarPersonal();

        [OperationContract]
        Boolean InsertarPersonal(PersonalDC objPersonal);

        [OperationContract]
        Boolean ActualizarPersonal(PersonalDC objPersonal);
        [OperationContract]
        PersonalDC ValidarUsuario(String user, String pass);
    }

    [DataContract]
    [Serializable]
    public class PersonalDC
    {
        [DataMember]
        public Int16 per_id { get; set; }

        [DataMember]
        public String per_nom { get; set; }

        [DataMember]
        public String per_ape_pat { get; set; }

        [DataMember]
        public String per_ape_mat { get; set; }

        [DataMember]
        public String per_dir { get; set; }

        [DataMember]
        public String ubg_id { get; set; }

        [DataMember]
        [MaxLength(8), MinLength(8)]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo digitos")]
        public String per_dni { get; set; }

        [DataMember]
        public String per_tel { get; set; }

        [DataMember]
        public String per_mail { get; set; }

        [DataMember]
        public String per_pass { get; set; }

        [DataMember]
        public Byte[] per_foto { get; set; }

        [DataMember]
        public DateTime per_fec_ing { get; set; }

        [DataMember]
        public String per_user_reg { get; set; }

        [DataMember]
        public DateTime? per_fec_reg { get; set; }

        [DataMember]
        public String per_user_mod { get; set; }

        [DataMember]
        public DateTime? per_fec_mod { get; set; }

        [DataMember]
        public Int16 per_state { get; set; }
        [DataMember]
        public String Estado { get; set; }

    }
}
