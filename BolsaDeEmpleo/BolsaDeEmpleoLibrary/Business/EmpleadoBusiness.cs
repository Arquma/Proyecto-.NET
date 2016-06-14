using BolsaDeEmpleoLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{
    public class EmpleadoBusiness
    {
        private string coneccion;
        private EmpleadoData empleadoData;

        public EmpleadoBusiness(string coneccion)
        {
            this.coneccion = coneccion;
            empleadoData = new EmpleadoData(this.coneccion);

        }

        public Boolean confirmLogin(String user, String pass)
        {
            return empleadoData.confirmLogin(user, pass);
        }

    }
}
