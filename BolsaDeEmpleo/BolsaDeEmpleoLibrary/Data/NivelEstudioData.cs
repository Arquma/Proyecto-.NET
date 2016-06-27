using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class NivelEstudioData
    {

        private string conectionString;
        public NivelEstudioData(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public LinkedList<NivelEstudio> GetNivelEstudio()
        {

            SqlConnection conexion = new SqlConnection(conectionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select cod_nivel_estudio, descripcion_nivel_estudio from Nivel_Estudio ", conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drArea = cmdLogin.ExecuteReader();
            LinkedList<NivelEstudio> areas = new LinkedList<NivelEstudio>();
            while (drArea.Read())
            {

                //----------Libro----------//
                NivelEstudio area = new NivelEstudio();
                area.CodNivelEstudio = Int32.Parse(drArea["cod_nivel_estudio"].ToString());
                area.DescripcionNivelEstudio = drArea["descripcion_nivel_estudio"].ToString();

                areas.AddLast(area);


            }//fin while

            conexion.Close();

            return areas;
        }

    }
}
