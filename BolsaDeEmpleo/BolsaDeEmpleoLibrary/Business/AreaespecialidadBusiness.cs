using BolsaDeEmpleoLibrary.Data;
using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{
    public class AreaEspecialidadBusiness
    {

        private string conectionString;
        private AreaEspecialidadData area;
        public AreaEspecialidadBusiness(string conectionString)
        {
            this.conectionString = conectionString;
            area = new AreaEspecialidadData(this.conectionString);
        }

        public LinkedList<AreaEspecialidad> GetAreas()
        {
            return area.GetAreas();
        }

        }
}
