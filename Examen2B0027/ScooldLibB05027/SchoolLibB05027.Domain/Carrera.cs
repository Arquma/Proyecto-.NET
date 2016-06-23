using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooldLibB05027.SchoolLibB05027.Domain
{
    public class Carrera
    {
        private int codCarrera;
        private string nombreCarrera;

        public Carrera()
        {

        }

        public int CodCarrera
        {
            get
            {
                return codCarrera;
            }

            set
            {
                codCarrera = value;
            }
        }

        public string NombreCarrera
        {
            get
            {
                return nombreCarrera;
            }

            set
            {
                nombreCarrera = value;
            }
        }
    }
}
