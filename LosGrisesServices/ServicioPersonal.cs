using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    public class ServicioPersonal : IServicioPersonal
    {
        // Acceso a la base de datos (dbLibreriaEntities debe estar correctamente configurado en tu proyecto)
        dbLibreriaEntities Libreria = new dbLibreriaEntities();

        // Método para consultar los datos de un personal por su ID
        public PersonalDC ConsultarPersonal(Int16 strCodigo)
        {
            try
            {
                // Crear un objeto de datos de contrato
                PersonalDC objPersonal = new PersonalDC();

                // Consulta en la base de datos
                tb_Personal objConsulta = (
                    from personal in Libreria.tb_Personal
                    where personal.per_id == strCodigo
                    select personal
                ).FirstOrDefault();

                // Verificar si se encontraron datos
                if (objConsulta != null)
                {
                    objPersonal.per_id = Convert.ToInt16(objConsulta.per_id);
                    objPersonal.per_nom = objConsulta.per_nom;
                    objPersonal.per_ape_pat = objConsulta.per_ape_pat;
                    objPersonal.per_ape_mat = objConsulta.per_ape_mat;
                    objPersonal.per_dir = objConsulta.per_dir;
                    objPersonal.ubg_id = objConsulta.ubg_id;
                    objPersonal.per_dni = objConsulta.per_dni;
                    objPersonal.per_tel = objConsulta.per_tel;
                    objPersonal.per_mail = objConsulta.per_mail;
                    objPersonal.per_pass = objConsulta.per_pass;
                    objPersonal.per_foto = objConsulta.per_foto;
                    objPersonal.per_fec_ing = Convert.ToDateTime(objConsulta.per_fec_ing);
                    objPersonal.per_user_reg = objConsulta.per_user_reg;
                    objPersonal.per_fec_reg = objConsulta.per_fec_reg;
                    objPersonal.per_user_mod = objConsulta.per_user_mod;
                    objPersonal.per_fec_mod = objConsulta.per_fec_mod;
                    objPersonal.per_state = Convert.ToInt16(objConsulta.per_state);
                }
                else
                {
                    objPersonal.per_id = 0; // Si no se encuentra, se devuelve un id de 0
                }

                return objPersonal;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Método para listar todos los registros de personal
        public List<PersonalDC> ListarPersonal()
        {
            try
            {
                List<PersonalDC> objLista = new List<PersonalDC>();

                // Consultar todos los registros en la tabla tb_Personal
                var query = (
                    from personal in Libreria.tb_Personal
                    orderby personal.per_ape_pat
                    select personal
                ).ToList();

                // Iterar sobre el resultado de la consulta
                foreach (var personal in query)
                {
                    PersonalDC objPersonal = new PersonalDC
                    {
                        per_id = (short)personal.per_id,
                        per_nom = personal.per_nom,
                        per_ape_pat = personal.per_ape_pat,
                        per_ape_mat = personal.per_ape_mat,
                        per_dir = personal.per_dir,
                        ubg_id = personal.ubg_id,
                        per_dni = personal.per_dni,
                        per_tel = personal.per_tel,
                        per_mail = personal.per_mail,
                        per_pass = personal.per_pass,
                        per_foto = personal.per_foto,
                        per_fec_ing = Convert.ToDateTime(personal.per_fec_ing),
                        per_user_reg = personal.per_user_reg,
                        per_fec_reg = personal.per_fec_reg,
                        per_user_mod = personal.per_user_mod,
                        per_fec_mod = personal.per_fec_mod,
                        per_state = Convert.ToInt16(personal.per_state)
                    };

                    objLista.Add(objPersonal);
                }

                return objLista;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Método para insertar un nuevo registro de personal
        public Boolean InsertarPersonal(PersonalDC objPersonal)
        {
            try
            {
                // Llamada al procedimiento almacenado para insertar
                Libreria.usp_InsertarPersonal
                (
                    objPersonal.per_nom,
                    objPersonal.per_ape_pat,
                    objPersonal.per_ape_mat,
                    objPersonal.per_dir,
                    objPersonal.ubg_id,
                    objPersonal.per_dni,
                    objPersonal.per_tel,
                    objPersonal.per_mail,
                    objPersonal.per_pass,
                    objPersonal.per_foto,
                    objPersonal.per_fec_ing,
                    objPersonal.per_user_reg
                );

                // Guardar los cambios en la base de datos
                Libreria.SaveChanges();

                return true;
            }
            catch (EntityException ex)
            {
                var detailedMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception($"Error al insertar el libro: {detailedMessage}");
            }
        }

        // Método para actualizar los datos de un registro de personal
        public Boolean ActualizarPersonal(PersonalDC objPersonal)
        {
            try
            {
                // Llamada al procedimiento almacenado para actualizar
                Libreria.usp_EditarPersonal
                (
                    objPersonal.per_id,
                    objPersonal.per_nom,
                    objPersonal.per_ape_pat,
                    objPersonal.per_ape_mat,
                    objPersonal.per_dir,
                    objPersonal.ubg_id,
                    objPersonal.per_dni,
                    objPersonal.per_tel,
                    objPersonal.per_mail,
                    objPersonal.per_pass,
                    objPersonal.per_foto,
                    objPersonal.per_fec_ing,
                    objPersonal.per_user_mod,
                    Convert.ToBoolean(objPersonal.per_state)
                );

                // Guardar los cambios en la base de datos
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
