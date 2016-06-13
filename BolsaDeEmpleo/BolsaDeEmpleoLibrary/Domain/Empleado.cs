using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class Empleado
    {
        int idEmpleado;
        string nombreEmpleado;
        string apellidos;
        string direccion;
        string cuidad;
        string provincia;
        int numeroCelular;
        int extencion;
        int telefonoCasa;
        string email;
        DateTime fechaNacimiento;
        string genero;
        string estadoCivil;
        RolEmpleado rolEmpleado;

        public int IdEmpleado
        {
            get
            {
                return idEmpleado;
            }

            set
            {
                idEmpleado = value;
            }
        }

        public string NombreEmpleado
        {
            get
            {
                return nombreEmpleado;
            }

            set
            {
                nombreEmpleado = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
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

        public string Cuidad
        {
            get
            {
                return cuidad;
            }

            set
            {
                cuidad = value;
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

        public int NumeroCelular
        {
            get
            {
                return numeroCelular;
            }

            set
            {
                numeroCelular = value;
            }
        }

        public int Extencion
        {
            get
            {
                return extencion;
            }

            set
            {
                extencion = value;
            }
        }

        public int TelefonoCasa
        {
            get
            {
                return telefonoCasa;
            }

            set
            {
                telefonoCasa = value;
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

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string EstadoCivil
        {
            get
            {
                return estadoCivil;
            }

            set
            {
                estadoCivil = value;
            }
        }

        public RolEmpleado RolEmpleado
        {
            get
            {
                return rolEmpleado;
            }

            set
            {
                rolEmpleado = value;
            }
        }

        public Empleado()
        {

        }

    }
}
