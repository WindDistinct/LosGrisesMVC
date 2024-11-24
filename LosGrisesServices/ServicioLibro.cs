using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LosGrisesServices
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioLibro" en el código y en el archivo de configuración a la vez.
    public class ServicioLibro : IServicioLibro
    {
        dbLibreriaEntities Libreria = new dbLibreriaEntities();

        public LibroViewDC ConsultarLibro(Int16 strCodigo)
        {
            try
            {
                LibroViewDC objLibro = new LibroViewDC();

                tb_Libro libro = (
                    from Libro in Libreria.tb_Libro
                    where Libro.lib_id == strCodigo
                    select Libro
                    ).FirstOrDefault();

                if (libro != null)
                {
                    objLibro.lib_id = (short)libro.lib_id;
                    objLibro.lib_nom = libro.lib_nom;
                    objLibro.aut_nom = libro.tb_Autor.aut_nom;
                    objLibro.aut_ape = libro.tb_Autor.aut_ape;
                    objLibro.gen_desc = libro.tb_Genero.gen_desc;
                    objLibro.edi_id = (short)libro.edi_id;
                    objLibro.lib_edi = libro.lib_edi;
                    objLibro.edi_nom = libro.tb_Editorial.edi_nom;
                    objLibro.lib_fec_pub = (short)libro.lib_fec_pub;
                    objLibro.lib_disp_stock = (short)libro.lib_disp_stock;
                    objLibro.lib_user_reg = libro.lib_user_reg;
                    objLibro.lib_fec_reg = libro.lib_fec_reg;
                    objLibro.lib_user_mod = libro.lib_user_mod;
                    objLibro.lib_fec_mod = libro.lib_fec_mod;
                    objLibro.aut_id = (short)libro.aut_id;
                    objLibro.gen_id = (short)libro.gen_id;
                    objLibro.lib_state = Convert.ToInt16(libro.lib_state);
                    if (objLibro.lib_state == 1)
                    {
                        objLibro.Estado = "Activo";
                    }
                    else
                    {
                        objLibro.Estado = "Inactivo";
                    }
                }
                else
                {
                    objLibro.lib_id = 0;
                }
                return objLibro;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<LibroViewDC> ListarLibro()
        {
            try
            {
                List<LibroViewDC> objLista = new List<LibroViewDC>();

                var query = (
                    from libro in Libreria.tb_Libro
                    orderby libro.lib_nom
                    select libro
                    ).ToList();

                foreach (var libro in query)
                {
                    LibroViewDC objLibro = new LibroViewDC();

                    objLibro.lib_id = (short)libro.lib_id;
                    objLibro.lib_nom = libro.lib_nom;
                    objLibro.aut_nom = libro.tb_Autor.aut_nom;
                    objLibro.aut_ape = libro.tb_Autor.aut_ape;
                    objLibro.gen_desc = libro.tb_Genero.gen_desc;
                    objLibro.lib_edi = libro.lib_edi;
                    objLibro.edi_id = (short)libro.edi_id;
                    objLibro.edi_nom = libro.tb_Editorial.edi_nom;
                    objLibro.lib_fec_pub = (short)libro.lib_fec_pub;
                    objLibro.lib_disp_stock = (short)libro.lib_disp_stock;
                    objLibro.lib_user_reg = libro.lib_user_reg;
                    objLibro.lib_fec_reg = libro.lib_fec_reg;
                    objLibro.lib_user_mod = libro.lib_user_mod;
                    objLibro.lib_fec_mod = libro.lib_fec_mod;
                    objLibro.aut_id = (short)libro.aut_id;
                    objLibro.gen_id = (short)libro.gen_id;
                    objLibro.lib_state = Convert.ToInt16(libro.lib_state);
                    if (objLibro.lib_state == 1)
                    {
                        objLibro.Estado = "Activo";
                    }
                    else
                    {
                        objLibro.Estado = "Inactivo";
                    }


                    objLista.Add(objLibro);
                }

                return objLista;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean InsertarLibro(LibroDC objLibro)
        {
            try
            {
                Libreria.usp_InsertarLibro(
                    objLibro.lib_nom,
                    objLibro.aut_id,
                    objLibro.gen_id,
                    objLibro.lib_edi,
                    objLibro.lib_fec_pub,
                    objLibro.lib_disp_stock,
                    objLibro.edi_id,
                    objLibro.lib_user_reg
                );

                Libreria.SaveChanges();

                return true;

            }
            catch (EntityException ex)
            {
                var detailedMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                throw new Exception($"Error al insertar el libro: {detailedMessage}");
            }
        }

        public Boolean ActualizarLibro(LibroDC objLibro)
        {
            try
            {
                Libreria.usp_EditarLibro
                    (
                        objLibro.lib_id,
                        objLibro.lib_nom,
                        objLibro.aut_id,
                        objLibro.gen_id,
                        objLibro.lib_edi,
                        objLibro.lib_fec_pub,
                        objLibro.lib_disp_stock,
                        objLibro.edi_id,
                        objLibro.lib_user_mod,
                        Convert.ToBoolean(objLibro.lib_state)
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

