using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioEditorial" in both code and config file together.
    [ServiceContract]
    public interface IServicioEditorial
    {
        [OperationContract]
        List<EditorialDC> ObtenerEditoriales();
    }

    [DataContract]
    [Serializable]
    public class EditorialDC
    {
        [DataMember]
        public String EditorialId { get; set; }
        [DataMember]
        public String EditorialNombre { get; set; }

    }

}
