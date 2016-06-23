using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooldLibB05027.SchoolLibB05027.Domain
{
    public class TituloAcademico
    {
        private int codTitulo;
        private string nombreTitulo;
        private string gradoAcademicoObtenido;
        private int anoObtencion;
        private string nombreUniversidad;


        public TituloAcademico()
        {

        }

        public int CodTitulo
        {
            get
            {
                return codTitulo;
            }

            set
            {
                codTitulo = value;
            }
        }

       

        public string GradoAcademicoObtenido
        {
            get
            {
                return gradoAcademicoObtenido;
            }

            set
            {
                gradoAcademicoObtenido = value;
            }
        }

        public int AnoObtencion
        {
            get
            {
                return anoObtencion;
            }

            set
            {
                anoObtencion = value;
            }
        }

        public string NombreUniversidad
        {
            get
            {
                return nombreUniversidad;
            }

            set
            {
                nombreUniversidad = value;
            }
        }

        public string NombreTitulo
        {
            get
            {
                return nombreTitulo;
            }

            set
            {
                nombreTitulo = value;
            }
        }
    }
}
