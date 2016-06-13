using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class AreaEspecialidad
    {
        int codAreaEspecialidad;
        String descripcionAreaEspecialidad;

        public AreaEspecialidad()
        {

        }

        public int CodAreaEspecialidad
        {
            get
            {
                return codAreaEspecialidad;
            }

            set
            {
                codAreaEspecialidad = value;
            }
        }

        public string DescripcionAreaEspecialidad
        {
            get
            {
                return descripcionAreaEspecialidad;
            }

            set
            {
                descripcionAreaEspecialidad = value;
            }
        }
    }
}
