using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioAutor" in both code and config file together.
    [ServiceContract]
    public interface IServicioAutor
    {
        [OperationContract]
        List<AutorDC> ObtenerAutores();
    }

    [DataContract]
    [Serializable]
    public class AutorDC
    {
        [DataMember]
        public int AutorId { get; set; }
        [DataMember]
        public String AutorNombreApellidos { get; set; }
    }
}
