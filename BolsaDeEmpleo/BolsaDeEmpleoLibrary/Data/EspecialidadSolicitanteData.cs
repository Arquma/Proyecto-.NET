using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{
    public class EspecialidadSolicitanteData
    {
        private string conectionString;
        public EspecialidadSolicitanteData(string conectionString)
        {
            this.conectionString = conectionString;
        }



        public Boolean insertarSolicitante(EspecialidadSolicitante especialidadSolicitante)
        {

            SqlConnection conexion = new SqlConnection(this.conectionString);
            SqlCommand cmdInsertarInstructor = new SqlCommand();
            cmdInsertarInstructor.CommandText = "insertar_solicitante";
            cmdInsertarInstructor.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarInstructor.Connection = conexion;
            SqlParameter parIdInstructor = new SqlParameter("@id_solicitante", System.Data.SqlDbType.Int);
            parIdInstructor.Direction = System.Data.ParameterDirection.Output;
            cmdInsertarInstructor.Parameters.Add(parIdInstructor);
        
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@nombre", especialidadSolicitante.SolicitanteTrabajo.Nombre));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@apellidos", especialidadSolicitante.SolicitanteTrabajo.Apellidos));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@direccion", especialidadSolicitante.SolicitanteTrabajo.Direccion));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@ciudad", especialidadSolicitante.SolicitanteTrabajo.Ciudad));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@email", especialidadSolicitante.SolicitanteTrabajo.Email));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@genero", especialidadSolicitante.SolicitanteTrabajo.Genero));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@nombre_usuario", especialidadSolicitante.SolicitanteTrabajo.NombreUsuario));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@clave", especialidadSolicitante.SolicitanteTrabajo.Clave));

            conexion.Open();
            
           
                cmdInsertarInstructor.ExecuteNonQuery();
                especialidadSolicitante.SolicitanteTrabajo.IdSolicitante = Int32.Parse(cmdInsertarInstructor.Parameters["@id_solicitante"].Value.ToString());

                ////Insertar los titulos del instructor
                foreach (ExperienciaLaboral experiencia in especialidadSolicitante.SolicitanteTrabajo.Experiencia)
                {
                    SqlCommand cmdInsertarExperiencia = new SqlCommand();
                    cmdInsertarExperiencia.CommandText = "insertar_experiencia";
                    cmdInsertarExperiencia.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdInsertarExperiencia.Connection = conexion;
                    SqlParameter para = new SqlParameter("@id_experiencia", System.Data.SqlDbType.Int);
                    para.Direction = System.Data.ParameterDirection.Output;
                    cmdInsertarExperiencia.Parameters.Add(para);
               
                    cmdInsertarExperiencia.Parameters.Add(new SqlParameter("@empresa", experiencia.Empresa));
                    cmdInsertarExperiencia.Parameters.Add(new SqlParameter("@descripcion_funciones", experiencia.DescripcionFunciones));
                    cmdInsertarExperiencia.Parameters.Add(new SqlParameter("@fecha_ingreso", experiencia.FechaIngreso));
                    cmdInsertarExperiencia.Parameters.Add(new SqlParameter("@fecha_termino", experiencia.FechaTermino));
                    cmdInsertarExperiencia.Parameters.Add(new SqlParameter("@id_solicitante", especialidadSolicitante.SolicitanteTrabajo.IdSolicitante));
                    cmdInsertarExperiencia.ExecuteNonQuery();

            }
                //---------------------------------------//

                //-----------------------Insertar Especialidad-------------------------??
                SqlCommand cmdInsertarEsp = new SqlCommand();
                cmdInsertarEsp.CommandText = "insertar_especialidad";
                cmdInsertarEsp.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInsertarEsp.Connection = conexion;

            cmdInsertarEsp.Parameters.Add(new SqlParameter("@id_solicitante", especialidadSolicitante.SolicitanteTrabajo.IdSolicitante));
                cmdInsertarEsp.Parameters.Add(new SqlParameter("@cod_nivel_estudio", especialidadSolicitante.NivelEstudio.CodNivelEstudio));
                cmdInsertarEsp.Parameters.Add(new SqlParameter("@cod_area_especialidad", especialidadSolicitante.AreaEspecialidad.CodAreaEspecialidad));
                cmdInsertarEsp.Parameters.Add(new SqlParameter("@cod_institucion", especialidadSolicitante.InsstitucionEstudio.CodInstitucion));
                cmdInsertarEsp.Parameters.Add(new SqlParameter("@nombre_titulo_obtenido", especialidadSolicitante.NombreTituloObtenido));
            
            cmdInsertarEsp.ExecuteNonQuery();



            conexion.Close();
           

            return true;
        }
    }
}
