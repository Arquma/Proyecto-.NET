﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class ContactoEmpleadorData
    {
        private String conetionString;
         

        public ContactoEmpleadorData(String conetionString)
        {
            this.conetionString = conetionString;
        }

        public Boolean confirmLogin(String user,String pass)
        {

            //----- 1-----//
            SqlConnection conexion = new SqlConnection(conetionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select count(id_contacto) usuario " +
                                                   " from Contacto_Empleador"+
                                                   " where nombre_usuario = '"+ user + "'"+
                                                   " and clave_acceso = '"+ pass + "'",conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drLogin = cmdLogin.ExecuteReader();
            int existe=0;
            while (drLogin.Read())
            {
                //----------Libro----------//
                
                 existe = Int32.Parse(drLogin["usuario"].ToString());
              
            }//fin while

            conexion.Close();
            if (existe==1)
            {
                return true;
            }
            return false;
        }

    }
}
