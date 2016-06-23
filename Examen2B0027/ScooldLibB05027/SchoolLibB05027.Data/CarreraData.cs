using ScooldLibB05027.SchoolLibB05027.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooldLibB05027.SchoolLibB05027.Data
{
    public class CarreraData
    {

        private string cadenaConexion;
        public CarreraData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }


        public DataSet GetCarreras() { 
        
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlDataAdapter daCarrreras = new SqlDataAdapter();
            daCarrreras.SelectCommand = new SqlCommand();
            daCarrreras.SelectCommand.Connection = conexion;
            daCarrreras.SelectCommand.CommandText = "select cod_carrera, nombre_carrera from Carrera";
           
            DataSet dsCarreras = new DataSet();
            daCarrreras.Fill(dsCarreras, "Carrera");
            return dsCarreras;
            
        }




    }
}





























