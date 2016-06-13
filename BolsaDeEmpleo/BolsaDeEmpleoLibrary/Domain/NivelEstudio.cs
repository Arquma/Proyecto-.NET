using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    

    public class NivelEstudio
    {

        int codNivelEstudio;
        String descripcionNivelEstudio;

        public NivelEstudio()
        {

        }

        public int CodNivelEstudio
        {
            get
            {
                return codNivelEstudio;
            }

            set
            {
                codNivelEstudio = value;
            }
        }

        public string DescripcionNivelEstudio
        {
            get
            {
                return descripcionNivelEstudio;
            }

            set
            {
                descripcionNivelEstudio = value;
            }
        }
    }
}
