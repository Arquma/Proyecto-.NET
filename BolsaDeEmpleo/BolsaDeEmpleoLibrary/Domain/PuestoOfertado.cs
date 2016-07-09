using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Domain
{
    public class PuestoOfertado
    {
        int idPuesto;
        string descripcionPuesto;
        string experienciaRequerida; 
        Boolean abierto;
        int numeroVacantes;
        string diasLaborales;
        string horaEntrada;
        string horaSalida;
        float sueldo;
        string provincia;
        string ciudad;
        ClienteEmpleador clienteEmpleador;
        CategoriaPuesto categoriaPuesto;

        public PuestoOfertado()
        {
            clienteEmpleador = new ClienteEmpleador();
            categoriaPuesto = new CategoriaPuesto();
        }

        public int IdPuesto
        {
            get
            {
                return idPuesto;
            }

            set
            {
                idPuesto = value;
            }
        }

        public string DescripcionPuesto
        {
            get
            {
                return descripcionPuesto;
            }

            set
            {
                descripcionPuesto = value;
            }
        }

        public string ExperienciaRequerida
        {
            get
            {
                return experienciaRequerida;
            }

            set
            {
                experienciaRequerida = value;
            }
        }

        public Boolean Abierto
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

        public int NumeroVacantes
        {
            get
            {
                return numeroVacantes;
            }

            set
            {
                numeroVacantes = value;
            }
        }

        public string DiasLaborales
        {
            get
            {
                return diasLaborales;
            }

            set
            {
                diasLaborales = value;
            }
        }

        public string HoraEntrada
        {
            get
            {
                return horaEntrada;
            }

            set
            {
                horaEntrada = value;
            }
        }

        public string HoraSalida
        {
            get
            {
                return horaSalida;
            }

            set
            {
                horaSalida = value;
            }
        }

        public float Sueldo
        {
            get
            {
                return sueldo;
            }

            set
            {
                sueldo = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                ciudad = value;
            }
        }

        internal ClienteEmpleador ClienteEmpleador
        {
            get
            {
                return clienteEmpleador;
            }

            set
            {
                clienteEmpleador = value;
            }
        }

        public CategoriaPuesto CategoriaPuesto
        {
            get
            {
                return categoriaPuesto;
            }

            set
            {
                categoriaPuesto = value;
            }
        }

      
    }
}
