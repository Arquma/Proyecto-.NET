using ScooldLibB05027.SchoolLibB05027.Data;
using ScooldLibB05027.SchoolLibB05027.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooldLibB05027.SchoolLibB05027.Business
{
    public class InstuctorBusiness
    {
        private string cadenaConexion;
        private InstructorData instructorData;

        public InstuctorBusiness(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            instructorData = new InstructorData(this.cadenaConexion);
        }

        public Instructor Insertar(Instructor instructor)
        {
            return instructorData.Insertar(instructor);
        }

        public LinkedList<Instructor> GetInstructores(int cod_carrera)
        {

            return instructorData.GetInstructores(cod_carrera);
        }





    }
}
