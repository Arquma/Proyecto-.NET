using BolsaDeEmpleoLibrary.Data;
using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{
    public class SolicitantePuestoOfertaBusiness
    {

        private string conectionString;
        private SolicitantePuestoOfertaData solicitantePuesto;
        public SolicitantePuestoOfertaBusiness(string conectionString)
        {
            this.conectionString = conectionString;
            solicitantePuesto = new SolicitantePuestoOfertaData(this.conectionString);
        }

        public Boolean insertarSolicitud(int id_solicitante, int clave)
        {
            
            return solicitantePuesto.insertarSolicitud(id_solicitante, clave);
        }

    }
}
