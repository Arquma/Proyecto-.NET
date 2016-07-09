using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class SolicitantePuestoOfertaData
    {

        private string conectionString;
        public SolicitantePuestoOfertaData(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public Boolean insertarSolicitud(int id_solicitante,int clave) {





            String query = "INSERT INTO Solicitante_PuestoOfertado (id_solicitante,clave_puesto,activo) VALUES(@id_solicitante,@clave_puesto,@activo)";
            SqlConnection conexion = new SqlConnection(conectionString);
            SqlCommand command = new SqlCommand(query, conexion);
            

            command.Parameters.Add(new SqlParameter("@id_solicitante", id_solicitante));
            command.Parameters.Add(new SqlParameter("@clave_puesto", clave));
            command.Parameters.Add(new SqlParameter("@activo", 1 ));



            conexion.Open();


            command.ExecuteNonQuery();

            return true;

        }


    }
}
