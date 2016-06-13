using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class InstitucionEstudio
    {
        int codInstitucion;
        String nombreInstitucion;

        public InstitucionEstudio()
        {

        }

        public int CodInstitucion
        {
            get
            {
                return codInstitucion;
            }

            set
            {
                codInstitucion = value;
            }
        }

        public string NombreInstitucion
        {
            get
            {
                return nombreInstitucion;
            }

            set
            {
                nombreInstitucion = value;
            }
        }
    }
}
