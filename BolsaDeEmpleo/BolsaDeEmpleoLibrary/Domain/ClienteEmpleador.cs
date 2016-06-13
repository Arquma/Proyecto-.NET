using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    class ClienteEmpleador
    {
        int idClienteEmpleado;
        string nombreCompania;
        string direccion;
        string ciudad;
        string provincia;
        int codigoPostal;

        public int IdClienteEmpleado
        {
            get
            {
                return idClienteEmpleado;
            }

            set
            {
                idClienteEmpleado = value;
            }
        }

        public string NombreCompania
        {
            get
            {
                return nombreCompania;
            }

            set
            {
                nombreCompania = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public int CodigoPostal
        {
            get
            {
                return codigoPostal;
            }

            set
            {
                codigoPostal = value;
            }
        }

        public ClienteEmpleador()
        {

        }
    }
}
