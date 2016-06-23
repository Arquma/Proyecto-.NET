using BolsaDeEmpleoLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{


    public class SolicitanteTrabajoBusiness
    {
        private string coneccion;
        private SolicitanteTrabajoData solicitanteData;

        public SolicitanteTrabajoBusiness(string coneccion)
        {
            this.coneccion = coneccion;
            solicitanteData = new SolicitanteTrabajoData(this.coneccion);
        }

        public Boolean confirmLogin(String user, String pass)
        {
            return solicitanteData.confirmLogin(user, pass);
        }


    }



}
