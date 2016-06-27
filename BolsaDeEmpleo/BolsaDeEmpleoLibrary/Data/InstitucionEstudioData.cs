using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class InstitucionEstudioData
    {

        private string conectionString;
        public InstitucionEstudioData(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public LinkedList<InstitucionEstudio> GetInstituciones()
        {

            SqlConnection conexion = new SqlConnection(conectionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select cod_institucion, nombre_institucion from Institucion_Estudio", conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drArea = cmdLogin.ExecuteReader();
            LinkedList<InstitucionEstudio> areas = new LinkedList<InstitucionEstudio>();
            while (drArea.Read())
            {

                //----------Libro----------//
                InstitucionEstudio area = new InstitucionEstudio();
                area.CodInstitucion = Int32.Parse(drArea["cod_institucion"].ToString());
                area.NombreInstitucion = drArea["nombre_institucion"].ToString();

                areas.AddLast(area);


            }//fin while

            conexion.Close();

            return areas;
        }
    }
}

