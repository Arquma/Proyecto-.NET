using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class EntrevistaProgramada
    {
        int idEntrevista;
        int tipoEntevista;
        DateTime fechaEntrevista;
        string horaEntrevista;
        PuestoOfertado puestoOfertado;
        Empleado empleado;
        SolicitanteTrabajo solicitanteTrabajo;

        public int IdEntrevista
        {
            get
            {
                return idEntrevista;
            }

            set
            {
                idEntrevista = value;
            }
        }

        public int TipoEntevista
        {
            get
            {
                return tipoEntevista;
            }

            set
            {
                tipoEntevista = value;
            }
        }

        public DateTime FechaEntrevista
        {
            get
            {
                return fechaEntrevista;
            }

            set
            {
                fechaEntrevista = value;
            }
        }

        public string HoraEntrevista
        {
            get
            {
                return horaEntrevista;
            }

            set
            {
                horaEntrevista = value;
            }
        }

        public PuestoOfertado PuestoOfertado
        {
            get
            {
                return puestoOfertado;
            }

            set
            {
                puestoOfertado = value;
            }
        }

        public Empleado Empleado
        {
            get
            {
                return empleado;
            }

            set
            {
                empleado = value;
            }
        }

        public SolicitanteTrabajo SolicitanteTrabajo
        {
            get
            {
                return solicitanteTrabajo;
            }

            set
            {
                solicitanteTrabajo = value;
            }
        }

        public EntrevistaProgramada()
        {

        }
    }

}
