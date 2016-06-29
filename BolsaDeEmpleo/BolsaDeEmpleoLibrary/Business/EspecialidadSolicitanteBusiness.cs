using BolsaDeEmpleoLibrary.Data;
using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{
    public class EspecialidadSolicitanteBusiness
    {
        private string conectionString;
        private EspecialidadSolicitanteData especialidadData;
        public EspecialidadSolicitanteBusiness(string conectionString)
        {
            this.conectionString = conectionString;
            especialidadData = new EspecialidadSolicitanteData(this.conectionString);
        }

        public Boolean insertarSolicitante(EspecialidadSolicitante especialidadSolicitante)
        {
            return this.especialidadData.insertarSolicitante(especialidadSolicitante);
        }

        }
}
