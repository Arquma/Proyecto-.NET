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

        public Boolean confirmLogin(String user, String pass)
        {

            //----- 1-----//
            SqlConnection conexion = new SqlConnection(conetionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select count(id_empleado) empleado " +
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

                existe = Int32.Parse(drLogin["empleado"].ToString());

            }//fin while

            conexion.Close();
            if (existe == 1)
            {
                return true;
            }
            return false;
        }


    }
}
