using BolsaDeEmpleoLibrary.Data;
using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{
    public class InstitucionEstudioBusiness
    {
        private string conectionString;
        private InstitucionEstudioData institucion;

        public InstitucionEstudioBusiness(string conectionString)
        {
            this.conectionString = conectionString;
            institucion = new InstitucionEstudioData(this.conectionString);

        }
        public LinkedList<InstitucionEstudio> GetInstituciones()
        {
            return institucion.GetInstituciones();
        }

        }
}
