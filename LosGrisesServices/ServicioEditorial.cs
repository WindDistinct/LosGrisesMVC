using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioEditorial" in both code and config file together.
    public class ServicioEditorial : IServicioEditorial
    {
        dbLibreriaEntities Libreria = new dbLibreriaEntities();

        public List<EditorialDC> ObtenerEditoriales()
        {
            try
            {
                List<EditorialDC> objLista = new List<EditorialDC>();

                var query = (
                    from editorial in Libreria.tb_Editorial
                    orderby editorial.edi_nom
                    select editorial
                    ).ToList();

                foreach (var resultado in query)
                {
                    EditorialDC objEditorial = new EditorialDC();

                    objEditorial.EditorialId = (short)resultado.edi_id;
                    objEditorial.EditorialNombre = resultado.edi_nom;

                    objLista.Add(objEditorial);
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
