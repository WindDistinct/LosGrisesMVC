using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioUbigeo" in both code and config file together.
    [ServiceContract]
    public interface IServicioUbigeo
    {
        [OperationContract]
        List<UbigeoDC> ObtenerUbigeos();
    }

    [DataContract]
    [Serializable]
    public class UbigeoDC
    {
        [DataMember]
        public String UbigeoId { get; set; }

        [DataMember]
        public String UbigeoDesc { get; set; }
    }
}
