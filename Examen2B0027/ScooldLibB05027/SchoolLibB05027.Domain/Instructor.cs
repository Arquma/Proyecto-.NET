using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooldLibB05027.SchoolLibB05027.Domain
{
    public class Instructor
    {
        private int idInstructor;
        private string nombreInstructor;
        private string apellidosInstructor;
        private string correoEletronico;
        private Carrera carrera;
        private LinkedList<TituloAcademico> titulosAcademicos;

        public Instructor()
        {
            Carrera = new Carrera();
            titulosAcademicos = new LinkedList<TituloAcademico>();
        }

        public int IdInstructor
        {
            get
            {
                return idInstructor;
            }

            set
            {
                idInstructor = value;
            }
        }

        public string NombreInstructor
        {
            get
            {
                return nombreInstructor;
            }

            set
            {
                nombreInstructor = value;
            }
        }

        public string ApellidosInstructor
        {
            get
            {
                return apellidosInstructor;
            }

            set
            {
                apellidosInstructor = value;
            }
        }

        public string CorreoEletronico
        {
            get
            {
                return correoEletronico;
            }

            set
            {
                correoEletronico = value;
            }
        }

        public Carrera Carrera
        {
            get
            {
                return carrera;
            }

            set
            {
                carrera = value;
            }
        }

        public LinkedList<TituloAcademico> TitulosAcademicos
        {
            get
            {
                return titulosAcademicos;
            }

            set
            {
                titulosAcademicos = value;
            }
        }
    }
}
