using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    public class ServicioCliente : IServicioCliente
    {
        dbLibreriaEntities Libreria = new dbLibreriaEntities();

        public ClienteDC ConsultarCliente(Int16 strCodigo)
        {
            try
            {
                ClienteDC objCliente = new ClienteDC();

                tb_Cliente objConsulta = (
                    from cliente in Libreria.tb_Cliente
                    where cliente.cli_id == strCodigo
                    select cliente
                    ).FirstOrDefault();

                if(objConsulta != null )
                {
                    objCliente.cli_nom = objConsulta.cli_nom;   
                    objCliente.cli_ape = objConsulta.cli_ape;
                    objCliente.cli_dir = objConsulta.cli_dir;
                    objCliente.cli_tel = objConsulta.cli_tel;
                    objCliente.cli_mail = objConsulta.cli_mail;
                    objCliente.cli_dni = objConsulta.cli_dni;
                    objCliente.Region = objConsulta.tb_Ubigeo.ubg_reg;
                    objCliente.Provincia = objConsulta.tb_Ubigeo.ubg_prov;
                    objCliente.Distrito = objConsulta.tb_Ubigeo.ubg_dist;
                    objCliente.cli_fec_nac = Convert.ToDateTime(objConsulta.cli_fec_nac);
                    objCliente.ubg_id = objConsulta.ubg_id;
                    objCliente.cli_sex = objConsulta.cli_sex;
                    objCliente.cli_foto = objConsulta.cli_foto;
                    objCliente.cli_state = Convert.ToInt16(objConsulta.cli_state);
                    if(objCliente.cli_state == 1)
                    {
                        objCliente.Estado = "Activo";
                    } 
                    else
                    {
                        objCliente.Estado = "Inactivo";
                    }
                } 
                else
                {
                    objCliente.cli_id = 0;
                }
                return objCliente;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<ClienteDC> ListarCliente()
        {
            try
            {
                List<ClienteDC> objLista = new List<ClienteDC>();

                var query = (
                    from cliente in Libreria.tb_Cliente
                    orderby cliente.cli_ape
                    select cliente
                    ).ToList();

                foreach(var cliente in query)
                {
                    ClienteDC objCliente = new ClienteDC();

                    objCliente.cli_id = (short)cliente.cli_id;
                    objCliente.cli_nom = cliente.cli_nom;
                    objCliente.cli_ape = cliente.cli_ape;
                    objCliente.cli_dir = cliente.cli_dir;
                    objCliente.cli_tel = cliente.cli_tel;
                    objCliente.cli_mail = cliente.cli_mail;
                    objCliente.cli_dni = cliente.cli_dni;
                    objCliente.ubg_id = cliente.ubg_id;
                    objCliente.Region = cliente.tb_Ubigeo.ubg_reg;
                    objCliente.Provincia = cliente.tb_Ubigeo.ubg_prov;
                    objCliente.Distrito = cliente.tb_Ubigeo.ubg_dist;
                    objCliente.cli_fec_nac = Convert.ToDateTime(cliente.cli_fec_nac);
                    objCliente.cli_sex = cliente.cli_sex;
                    objCliente.cli_foto = null; //cliente.cli_foto
                    objCliente.cli_state = Convert.ToInt16(cliente.cli_state);
                    if (objCliente.cli_state == 1)
                    {
                        objCliente.Estado = "Activo";
                    }
                    else
                    {
                        objCliente.Estado = "Inactivo";
                    }

                    objLista.Add(objCliente);
                }

                return objLista;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarCliente(ClienteDC objCliente)
        {
            try
            {
                Libreria.usp_InsertarCliente
                    (
                        objCliente.cli_nom,
                        objCliente.cli_ape,
                        objCliente.cli_dir,
                        objCliente.cli_tel,
                        objCliente.cli_mail,
                        objCliente.cli_dni,
                        objCliente.ubg_id,
                        objCliente.cli_fec_nac,
                        objCliente.cli_sex,
                        objCliente.cli_foto,
                        objCliente.cli_user_reg
                    );

                Libreria.SaveChanges();

                return true;
               
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarCliente(ClienteDC objCliente)
        {
            try
            {

                Libreria.usp_EditarCliente
                    (
                        objCliente.cli_id,
                        objCliente.cli_nom,
                        objCliente.cli_ape,
                        objCliente.cli_dir,
                        objCliente.cli_tel,
                        objCliente.cli_mail,
                        objCliente.cli_dni,
                        objCliente.ubg_id,
                        objCliente.cli_fec_nac,
                        objCliente.cli_sex,
                        objCliente.cli_foto,
                        objCliente.cli_user_mod,
                        Convert.ToBoolean(objCliente.cli_state)
                    );

                Libreria.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
