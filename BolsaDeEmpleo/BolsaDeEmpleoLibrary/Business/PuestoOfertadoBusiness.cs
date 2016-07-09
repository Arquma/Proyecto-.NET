using BolsaDeEmpleoLibrary.Data;
using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{


    public class PuestoOfertadoBusiness
    {
        private string conectionString;
        private PuestoOfertaData puestoData;
        public PuestoOfertadoBusiness(string conectionString)
        {
            this.conectionString = conectionString;
            puestoData = new PuestoOfertaData(this.conectionString);
        }

        public LinkedList<PuestoOfertado> GetOfertasPorCategoria(int idCategoria)
        {
            return puestoData.GetOfertasPorCategoria(idCategoria);
        }

    }
}
