using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class EspecialidadSolicitante
    {
        int anoInicio;
        int anoFinalizacion;
        String nombreTituloObtenido;
        SolicitanteTrabajo solicitanteTrabajo;
        NivelEstudio nivelEstudio;
        AreaEspecialidad areaEspecialidad;
        InstitucionEstudio insstitucionEstudio;

        public int AnoInicio
        {
            get
            {
                return anoInicio;
            }

            set
            {
                anoInicio = value;
            }
        }

        public int AnoFinalizacion
        {
            get
            {
                return anoFinalizacion;
            }

            set
            {
                anoFinalizacion = value;
            }
        }

        public string NombreTituloObtenido
        {
            get
            {
                return nombreTituloObtenido;
            }

            set
            {
                nombreTituloObtenido = value;
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

        public NivelEstudio NivelEstudio
        {
            get
            {
                return nivelEstudio;
            }

            set
            {
                nivelEstudio = value;
            }
        }

        public AreaEspecialidad AreaEspecialidad
        {
            get
            {
                return areaEspecialidad;
            }

            set
            {
                areaEspecialidad = value;
            }
        }

        public InstitucionEstudio InsstitucionEstudio
        {
            get
            {
                return insstitucionEstudio;
            }

            set
            {
                insstitucionEstudio = value;
            }
        }

        public EspecialidadSolicitante()
        {

        }

    }
}
