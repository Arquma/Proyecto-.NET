using ScooldLibB05027.SchoolLibB05027.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooldLibB05027.SchoolLibB05027.Business
{
    public class CarreraBusiness
    {
        private string cadenaConexion;
        private CarreraData carreraData;

        public CarreraBusiness(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            carreraData = new CarreraData(this.cadenaConexion);
        } 

        public DataSet GetCarreras()
        {
            return this.carreraData.GetCarreras();
        }

    }
}
