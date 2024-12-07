using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioGenero" in both code and config file together.
    public class ServicioGenero : IServicioGenero
    {

        dbLibreriaEntities Libreria = new dbLibreriaEntities();

        public List<GeneroDC> ObtenerGeneros()
        {
            try
            {
                List<GeneroDC> objLista = new List<GeneroDC>();

                var query = (
                    from genero in Libreria.tb_Genero
                    orderby genero.gen_desc
                    select genero
                    ).ToList();

                foreach (var resultado in query)
                {
                    GeneroDC objGenero = new GeneroDC();

                    objGenero.GeneroId = (short)resultado.gen_id;
                    objGenero.GeneroNombre = resultado.gen_desc;

                    objLista.Add(objGenero);
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
