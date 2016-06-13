using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    class ContactoEmpleador
    {
        int idContacto;
        String nombreContacto;
        String designacion;
        int telefono;
        int fax;
        string email;
        ClienteEmpleador clienteEmpleador;
        String nombreUsuario;
        string claveAcceso;

        public int IdContacto
        {
            get
            {
                return idContacto;
            }

            set
            {
                idContacto = value;
            }
        }

        public string NombreContacto
        {
            get
            {
                return nombreContacto;
            }

            set
            {
                nombreContacto = value;
            }
        }

        public string Designacion
        {
            get
            {
                return designacion;
            }

            set
            {
                designacion = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        internal ClienteEmpleador ClienteEmpleador
        {
            get
            {
                return clienteEmpleador;
            }

            set
            {
                clienteEmpleador = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return nombreUsuario;
            }

            set
            {
                nombreUsuario = value;
            }
        }

        public string ClaveAcceso
        {
            get
            {
                return claveAcceso;
            }

            set
            {
                claveAcceso = value;
            }
        }

        public ContactoEmpleador()
        {

        }
    }
}
