using BolsaDeEmpleoLibrary.Data;
using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{
    public class NivelEstudioBusiness
    {

        private string conectionString;
        private NivelEstudioData nivel;
        public NivelEstudioBusiness(string conectionString)
        {
            this.conectionString = conectionString;
            nivel = new NivelEstudioData(this.conectionString);
        }

        public LinkedList<NivelEstudio> GetNivelEstudio()
        {
            return nivel.GetNivelEstudio();
        }



        }
}
