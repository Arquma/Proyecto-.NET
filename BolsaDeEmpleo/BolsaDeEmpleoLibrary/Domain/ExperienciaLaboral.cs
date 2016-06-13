using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class ExperienciaLaboral
    {
        int idExperiencia;
        string empresa;
        string puesto;
        DateTime fechaIngreso;
        DateTime fechaTermino;
        string descripcionFunciones;

        public int IdExperiencia
        {
            get
            {
                return idExperiencia;
            }

            set
            {
                idExperiencia = value;
            }
        }

        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                empresa = value;
            }
        }

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }

            set
            {
                fechaIngreso = value;
            }
        }

        public DateTime FechaTermino
        {
            get
            {
                return fechaTermino;
            }

            set
            {
                fechaTermino = value;
            }
        }

        public string DescripcionFunciones
        {
            get
            {
                return descripcionFunciones;
            }

            set
            {
                descripcionFunciones = value;
            }
        }

        public ExperienciaLaboral()
        {

        }
    }
}
