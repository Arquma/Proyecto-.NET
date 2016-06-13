using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class RolEmpleado
    {
        int idRol;
        string nombrRol;

        public RolEmpleado()
        {

        }

        public int IdRol
        {
            get
            {
                return idRol;
            }

            set
            {
                idRol = value;
            }
        }

        public string NombrRol
        {
            get
            {
                return nombrRol;
            }

            set
            {
                nombrRol = value;
            }
        }
    }
}
