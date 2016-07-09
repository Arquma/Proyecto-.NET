using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class EmpleadoData
    {
        private string conetionString;

        public EmpleadoData(string conetionString)
        {
            this.conetionString = conetionString;
        }

        public int confirmLogin(String user, String pass)
        {

            //----- 1-----//
            SqlConnection conexion = new SqlConnection(conetionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select id_empleado " +
                                                   " from Empleado" +
                                                   " where usuario = '" + user + "'" +
                                                   " and password = '" + pass + "'", conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drLogin = cmdLogin.ExecuteReader();
            int existe = 0;
            while (drLogin.Read())
            {
                //----------Libro----------//

                existe = Int32.Parse(drLogin["id_empleado"].ToString());

            }//fin while

            conexion.Close();
            if (existe != 0)
            {
                return Int32.Parse(drLogin["id_empleado"].ToString());
            }
            return 0;
        }


    }
}
