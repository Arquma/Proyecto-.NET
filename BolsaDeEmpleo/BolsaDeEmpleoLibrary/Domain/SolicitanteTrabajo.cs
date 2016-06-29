using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class SolicitanteTrabajo
    {
        int idSolicitante;
        string nombre;
        string apellidos;
        string direccion;
        string ciudad;
        string provincia;
        string numeroCelular;
        string telefonoCasa;
        DateTime fechaNacimiento;
        string genero;
        string email;
        string estadoCivil;
        //archivoCurriculo
        string nombreUsuario;
        string clave;
        Boolean solicitanteActivo;
        Boolean experienciaLaboral;
        LinkedList<ExperienciaLaboral> experiencia;


        public SolicitanteTrabajo()
        {
            Experiencia = new LinkedList<ExperienciaLaboral>();
        }

        public int IdSolicitante
        {
            get
            {
                return idSolicitante;
            }

            set
            {
                idSolicitante = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
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

        public string NumeroCelular
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

        public string TelefonoCasa
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

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public bool SolicitanteActivo
        {
            get
            {
                return solicitanteActivo;
            }

            set
            {
                solicitanteActivo = value;
            }
        }

        public bool ExperienciaLaboral
        {
            get
            {
                return experienciaLaboral;
            }

            set
            {
                experienciaLaboral = value;
            }
        }

        public LinkedList<ExperienciaLaboral> Experiencia
        {
            get
            {
                return experiencia;
            }

            set
            {
                experiencia = value;
            }
        }
    }
}
