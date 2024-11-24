using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    public class ServicioConsultas : IServicioConsultas
    {
        dbLibreriaEntities Libreria = new dbLibreriaEntities();

        // Método para obtener los libros más alquilados
        public List<LibroAlquilado> ObtenerLibrosMasAlquilados(DateTime fechaInicio, DateTime fechaFin, String libro)
        {
            try
            {
                var query = Libreria.usp_LibrosMasAlquilados(fechaInicio, fechaFin, libro).ToList();

                List<LibroAlquilado> libros = new List<LibroAlquilado>();
                foreach (var item in query)
                {
                    libros.Add(new LibroAlquilado
                    {
                        Titulo = item.Titulo,
                        VecesAlquilado = item.VecesAlquilado ?? 0
                    });
                }

                return libros;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Método para consultar cuántos ejemplares hay disponibles para un libro
        public List<Ejemplar> ConsultarEjemplaresDisponibles(String libro)
        {
            try
            {
                var query = Libreria.usp_ConsultarEjemplaresDisponibles(libro).ToList();

                List<Ejemplar> ejemplar = new List<Ejemplar>();
                foreach (var item in query)
                {
                    ejemplar.Add(new Ejemplar
                    {
                        Libro = item.Libro,
                        Cantidad = item.Cantidad ?? 0,
                        Disponibilidad = item.Disponibilidad
                    });
                }

                return ejemplar;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Método para obtener los géneros más solicitados
        public List<GeneroSolicitado> ObtenerGenerosMasSolicitados()
        {
            try
            {
                var query = Libreria.usp_GenerosMasSolicitados().ToList();

                List<GeneroSolicitado> generos = new List<GeneroSolicitado>();
                foreach (var item in query)
                {
                    generos.Add(new GeneroSolicitado
                    {
                        Genero = item.Genero,
                        VecesSolicitado = item.VecesSolicitado ?? 0
                    });
                }

                return generos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Método para obtener las editoriales más alquiladas
        public List<EditorialAlquilada> ObtenerEditorialesMasAlquiladas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                var query = Libreria.usp_EditorialesMasAlquiladas(fechaInicio, fechaFin).ToList();

                List<EditorialAlquilada> editoriales = new List<EditorialAlquilada>();
                foreach (var item in query)
                {
                    editoriales.Add(new EditorialAlquilada
                    {
                        Editorial = item.Editorial,
                        VecesAlquilada = item.VecesAlquilada ?? 0
                    });
                }

                return editoriales;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Renta> ObtenerRentasPorFechas(DateTime fechaInicio, DateTime fechaFin, String cliente)
        {

            try
            {
                List<Renta> listaRentas = new List<Renta>();

                var query = Libreria.usp_ObtenerRentasPorFechas(fechaInicio,fechaFin, cliente).ToList();

                foreach (var renta in query)
                {
                    Renta objRenta = new Renta
                    {
                        rent_id = renta.rent_id,
                        rent_fec = renta.rent_fec,
                        cliente = renta.cliente,
                        lib_nom = renta.lib_nom,
                        rent_obs = renta.rent_obs,
                    };

                    listaRentas.Add(objRenta);
                }

                return listaRentas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al consultar las rentas: {ex.Message}");
            }
        }

    }
}
