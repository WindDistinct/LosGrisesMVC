using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioAutor" in both code and config file together.
    public class ServicioAutor : IServicioAutor
    {

        dbLibreriaEntities Libreria = new dbLibreriaEntities();

        public List<AutorDC> ObtenerAutores()
        {
            try
            {
                List<AutorDC> objLista = new List<AutorDC>();

                var query = (
                    from autor in Libreria.tb_Autor
                    orderby autor.aut_ape
                    select autor ).ToList();

                foreach (var resultado in query)
                {
                    AutorDC objAutor = new AutorDC();

                    objAutor.AutorId = resultado.aut_id;
                    objAutor.AutorNombreApellidos = $"{resultado.aut_ape}, {resultado.aut_nom}";

                    objLista.Add(objAutor);

                }

                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);    
            }
        }
    }
}
