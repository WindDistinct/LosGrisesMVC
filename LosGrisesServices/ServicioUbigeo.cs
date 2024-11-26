using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioUbigeo" in both code and config file together.
    public class ServicioUbigeo : IServicioUbigeo
    {
        dbLibreriaEntities Libreria = new dbLibreriaEntities();

        public List<UbigeoDC> ObtenerUbigeos()
        {
            try
            {
                List<UbigeoDC> objLista = new List<UbigeoDC> ();

                var query = (
                    from ubigeo in Libreria.tb_Ubigeo
                    orderby ubigeo.ubg_reg
                    select ubigeo
                    ).ToList();

                foreach(var resultado in query )
                {
                    UbigeoDC objUbigeo = new UbigeoDC ();

                    objUbigeo.UbigeoId = resultado.ubg_id;
                    objUbigeo.UbigeoDesc = $"{resultado.ubg_reg} -  {resultado.ubg_prov} - {resultado.ubg_dist}";

                    objLista.Add(objUbigeo);
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
