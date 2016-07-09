using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class PuestoOfertaData
    {

        private string conectionString;
        public PuestoOfertaData(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public LinkedList<PuestoOfertado> GetOfertasPorCategoria(int idCategoria)
        {

            SqlConnection conexion = new SqlConnection(conectionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select clave_puesto,descripcion_puesto,experiencia_requerida, "+
                                                    "abierto, numero_vacantes, dias_laborar, hora_entrada, hora_salida, sueldo, provincia, ciudad, "+
                                                    "id_cliente_empleador, cod_categoria "+
                                                    "from PuestoOfertado "+
                                                    "where cod_categoria = "+ idCategoria, conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drOferta = cmdLogin.ExecuteReader();
            LinkedList<PuestoOfertado> puestos = new LinkedList<PuestoOfertado>();
            while (drOferta.Read())
            {

                //----------Libro----------//
                PuestoOfertado puesto = new PuestoOfertado();
                 puesto.IdPuesto = Int32.Parse(drOferta["clave_puesto"].ToString());
                 puesto.DescripcionPuesto = drOferta["descripcion_puesto"].ToString();
                puesto.ExperienciaRequerida = drOferta["experiencia_requerida"].ToString();
                puesto.Abierto = Boolean.Parse(drOferta["abierto"].ToString());
                puesto.NumeroVacantes = Int32.Parse(drOferta["numero_vacantes"].ToString());
                puesto.DiasLaborales = drOferta["dias_laborar"].ToString();
                puesto.HoraEntrada = drOferta["hora_entrada"].ToString();
                puesto.HoraSalida = drOferta["hora_salida"].ToString();
                puesto.Sueldo = float.Parse(drOferta["sueldo"].ToString());
                puesto.Provincia = drOferta["provincia"].ToString();
                puesto.Ciudad = drOferta["ciudad"].ToString();
                puesto.CategoriaPuesto.CodCategoria= Int32.Parse(drOferta["cod_categoria"].ToString());
                puesto.ClienteEmpleador.IdClienteEmpleado = Int32.Parse(drOferta["id_cliente_empleador"].ToString());



                puestos.AddLast(puesto);


            }//fin while

            conexion.Close();

            return puestos;
        }
    }

}
