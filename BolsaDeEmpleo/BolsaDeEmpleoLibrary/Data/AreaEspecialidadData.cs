using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class AreaEspecialidadData
    {
        private string conectionString;
        public AreaEspecialidadData(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public LinkedList<AreaEspecialidad> GetAreas()
        {

            SqlConnection conexion = new SqlConnection(conectionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select cod_area_especialidad, descripcion_area_especialidad "+
                                                    "from Area_Especialidad ", conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drArea = cmdLogin.ExecuteReader();
            LinkedList<AreaEspecialidad> areas = new LinkedList<AreaEspecialidad>();
            while (drArea.Read())
            {

                //----------Libro----------//
                AreaEspecialidad area = new AreaEspecialidad();
                area.CodAreaEspecialidad = Int32.Parse(drArea["cod_area_especialidad"].ToString());
                area.DescripcionAreaEspecialidad = drArea["descripcion_area_especialidad"].ToString();

                areas.AddLast(area);


            }//fin while

            conexion.Close();
         
            return areas;
        }
    }
}
