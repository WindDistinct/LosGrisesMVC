using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    [ServiceContract]
    public interface IServicioConsultas
    {
        [OperationContract]
        List<LibroAlquilado> ObtenerLibrosMasAlquilados(DateTime fechaInicio, DateTime fechaFin, String libro);

        [OperationContract]
        List<Ejemplar> ConsultarEjemplaresDisponibles(String libro);

        [OperationContract]
        List<GeneroSolicitado> ObtenerGenerosMasSolicitados();

        [OperationContract]
        List<EditorialAlquilada> ObtenerEditorialesMasAlquiladas(DateTime fechaInicio, DateTime fechaFin);

        [OperationContract]
        List<Renta> ObtenerRentasPorFechas(DateTime fechaInicio, DateTime fechaFin, String cliente);
    }

    [DataContract]
    [Serializable]
    public class LibroAlquilado
    {
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public int VecesAlquilado { get; set; }
    }

    [DataContract]
    [Serializable]
    public class GeneroSolicitado
    {
        [DataMember]
        public string Genero { get; set; }
        [DataMember]
        public int VecesSolicitado { get; set; }
    }

    [DataContract]
    [Serializable]
    public class EditorialAlquilada
    {
        [DataMember]
        public string Editorial { get; set; }
        [DataMember]
        public int VecesAlquilada { get; set; }
    }

    [DataContract]
    [Serializable]
    public class Renta
    {
        [DataMember]
        public int rent_id { get; set; }
        [DataMember]
        public DateTime rent_fec { get; set; }
        [DataMember]
        public string cliente { get; set; }
        [DataMember]
        public string lib_nom { get; set; }
        [DataMember]
        public string rent_obs { get; set; }
    }

    [DataContract]
    [Serializable]
    public class Ejemplar
    {
        [DataMember]
        public string Libro { get; set; }
        [DataMember]
        public int Cantidad { get; set; }
        [DataMember]
        public string Disponibilidad { get; set; }
    }
}
