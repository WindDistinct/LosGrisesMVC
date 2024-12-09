using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioLogin" in both code and config file together.
    public class ServicioLogin : IServicioLogin
    {
        private readonly dbLibreriaEntities Libreria = new dbLibreriaEntities();
        public bool AutenticarUsuario(string username, string password)
        {
            try 
            {
                var usuario = Libreria.tb_Personal.FirstOrDefault(p => p.per_mail == username && p.per_pass == password);

                if(usuario != null)
                {
                    return true;    
                }
                else
                {
                    return false;
                }
            } 
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
