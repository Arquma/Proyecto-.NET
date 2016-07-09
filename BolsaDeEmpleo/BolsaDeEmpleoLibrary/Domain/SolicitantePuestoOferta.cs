using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class SolicitantePuestoOferta
    {
        private int idSolicitante;
        private int clavePuesto;
        private int abierto;

        public int IdSolicitante
        {
            get
            {
                return idSolicitante;
            }

            set
            {
                idSolicitante = value;
            }
        }

        public int ClavePuesto
        {
            get
            {
                return clavePuesto;
            }

            set
            {
                clavePuesto = value;
            }
        }

        public int Abierto
        {
            get
            {
                return abierto;
            }

            set
            {
                abierto = value;
            }
        }

        public SolicitantePuestoOferta()
        {

        }



    }
}
