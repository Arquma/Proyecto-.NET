using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class SolicitanteTrabajoData
    {
        private string conectionString;

        public SolicitanteTrabajoData(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public int confirmLogin(String user, String pass)
        {
            
            SqlConnection conexion = new SqlConnection(conectionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select id_solicitante  " +
                                                   " from Solicitante_Trabajo" +
                                                   " where nombre_usuario = '" + user + "'" +
                                                   " and clave = '" + pass + "'", conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drLogin = cmdLogin.ExecuteReader();
            int existe = 0;
            while (drLogin.Read())
            {
                

                existe = Int32.Parse(drLogin["id_solicitante"].ToString());

            }//fin while

            conexion.Close();
            if (existe != 0)
            {
                return existe;
            }
            return 0;
        }


       



    }
}
