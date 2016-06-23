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
    public class InstructorData
    {
        private string cadenaConexion;
        public InstructorData(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public Instructor Insertar(Instructor instructor)
        {
            SqlConnection conexion = new SqlConnection(this.cadenaConexion);
            SqlCommand cmdInsertarInstructor = new SqlCommand();
            cmdInsertarInstructor.CommandText = "insertar_instructor";
            cmdInsertarInstructor.CommandType = System.Data.CommandType.StoredProcedure;
            cmdInsertarInstructor.Connection = conexion;
            SqlParameter parIdInstructor = new SqlParameter("@id_instructor", System.Data.SqlDbType.Int);
            parIdInstructor.Direction = System.Data.ParameterDirection.Output;
            cmdInsertarInstructor.Parameters.Add(parIdInstructor);

            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@nombre_instructor", instructor.NombreInstructor));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@apellidos_instructor", instructor.ApellidosInstructor));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@correo_electronico", instructor.CorreoEletronico));
            cmdInsertarInstructor.Parameters.Add(new SqlParameter("@cod_carrera", instructor.Carrera.CodCarrera));

            conexion.Open();
            SqlTransaction transaccion = conexion.BeginTransaction();
            try
            {
                cmdInsertarInstructor.ExecuteNonQuery();
                instructor.IdInstructor = Int32.Parse(cmdInsertarInstructor.Parameters["@id_instructor"].Value.ToString());

                ////Insertar los titulos del instructor
                foreach (TituloAcademico titulo in instructor.TitulosAcademicos)
                {
                    SqlCommand cmdInsertarTituloAcademico = new SqlCommand();
                    cmdInsertarInstructor.CommandText = "insertar_titulo_academico";
                    cmdInsertarInstructor.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdInsertarInstructor.Connection = conexion;
                    SqlParameter par = new SqlParameter("@cod_titulo", System.Data.SqlDbType.Int);
                    parIdInstructor.Direction = System.Data.ParameterDirection.Output;
                    cmdInsertarInstructor.Parameters.Add(parIdInstructor);

                    cmdInsertarInstructor.Parameters.Add(new SqlParameter("@nombre_titulo", titulo.NombreTitulo));
                    cmdInsertarInstructor.Parameters.Add(new SqlParameter("@grado_academico_obtenido", titulo.GradoAcademicoObtenido));
                    cmdInsertarInstructor.Parameters.Add(new SqlParameter("@ano_obtencion", titulo.AnoObtencion));
                    cmdInsertarInstructor.Parameters.Add(new SqlParameter("@id_instructor", instructor.IdInstructor));
                    cmdInsertarInstructor.Parameters.Add(new SqlParameter("@nombre_universidad", titulo.NombreUniversidad));

                }
                //---------------------------------------//



                transaccion.Commit();
            }
            catch (Exception)
            {
                transaccion.Rollback();
                throw;
            }
            finally
            {
                conexion.Close();
            }


            return instructor;
        }

       
        public LinkedList<TituloAcademico> GetTituloAcademicosDeInstructor(int id_instructor)
        {
            LinkedList<TituloAcademico> titulos = new LinkedList<TituloAcademico>();
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            
            SqlCommand cmdTitulos = new SqlCommand("select cod_titulo, nombre_titulo, grado_academico_obtenido, ano_obtencion_titulo, id_instructor, nombre_universidad " +
                                                    "from TituloAcademico "+
                                                    "where id_instructor = " + id_instructor, conexion);
            conexion.Open();
           
           
                SqlDataReader drTitulos = cmdTitulos.ExecuteReader();

                while (drTitulos.Read())
                {
                    TituloAcademico titulo = new TituloAcademico();
                    titulo.CodTitulo = Int32.Parse(drTitulos["cod_titulo"].ToString());
                    titulo.NombreTitulo = (drTitulos["nombre_titulo"].ToString());
                    titulo.GradoAcademicoObtenido = (drTitulos["grado_academico_obtenido"].ToString());
                    titulo.AnoObtencion = Int32.Parse(drTitulos["ano_obtencion_titulo"].ToString());
                    titulo.NombreUniversidad = (drTitulos["nombre_universidad"].ToString());



                    titulos.AddLast(titulo);
                }//fin while
              


        
                conexion.Close();
             


            
            return titulos;


        }

        public LinkedList<Instructor> GetInstructores(int cod_carrera)
        {
            
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            
            SqlDataAdapter daInstructores = new SqlDataAdapter();
            daInstructores.SelectCommand = new SqlCommand();
            daInstructores.SelectCommand.Connection = conexion;
            daInstructores.SelectCommand.CommandText = "select  id_instructor,nombre_instructor,apellidos_instructor,correo_electronico,cod_carrera "+
                                                       "from Instructor where cod_carrera = "+ cod_carrera;


            DataSet dsIstructores = new DataSet();
            daInstructores.Fill(dsIstructores, "Instructor");
            LinkedList<Instructor> generos = new LinkedList<Instructor>();

            foreach (DataRow fila in dsIstructores.Tables["Instructor"].Rows)
            {

                Instructor instructor = new Instructor();
                instructor.IdInstructor = Int32.Parse(fila["id_instructor"].ToString());
                instructor.NombreInstructor = fila["nombre_instructor"].ToString();
                instructor.ApellidosInstructor = fila["apellidos_instructor"].ToString();
                instructor.CorreoEletronico = fila["correo_electronico"].ToString();
                instructor.TitulosAcademicos = GetTituloAcademicosDeInstructor(instructor.IdInstructor);

                generos.AddLast(instructor);
            }
            return generos;


        }


    }
}


