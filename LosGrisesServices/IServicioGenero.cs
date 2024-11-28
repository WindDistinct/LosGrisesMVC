using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioGenero" in both code and config file together.
    [ServiceContract]
    public interface IServicioGenero
    {
        [OperationContract]
        List<GeneroDC> ObtenerGeneros();
    }

    [DataContract]
    [Serializable]
    public class GeneroDC
    {
        [DataMember]
        public String GeneroId { get; set; }
        [DataMember]
        public String GeneroNombre { get; set; }
    }

}
