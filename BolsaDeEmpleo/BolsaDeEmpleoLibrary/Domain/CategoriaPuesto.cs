using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class CategoriaPuesto
    {
        int codCategoria;
        string nombreCategoria;

        public CategoriaPuesto()
        {

        }

        public int CodCategoria
        {
            get
            {
                return codCategoria;
            }

            set
            {
                codCategoria = value;
            }
        }

        public string NombreCategoria
        {
            get
            {
                return nombreCategoria;
            }

            set
            {
                nombreCategoria = value;
            }
        }
    }
}
