using BolsaDeEmpleoLibrary.Data;
using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{
    public class CategoriaPuestoBusiness
    {
        private string conectionString;
        private CategoriaPuestoData categoria;
        public CategoriaPuestoBusiness(string conectionString)
        {
            this.conectionString = conectionString;
            categoria = new CategoriaPuestoData(this.conectionString);
        }

        public LinkedList<CategoriaPuesto> GetCategorias()
        {
            return categoria.GetCategorias();
        }

    }
}

