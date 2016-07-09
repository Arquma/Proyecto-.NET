using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Data
{


    public class CategoriaPuestoData
    {
        private string conectionString;
        public CategoriaPuestoData(string conectionString)
        {
            this.conectionString = conectionString;
        }

        public LinkedList<CategoriaPuesto> GetCategorias()
        {

            SqlConnection conexion = new SqlConnection(conectionString);
            //----- 2-----//
            SqlCommand cmdLogin = new SqlCommand("select cod_categoria, nombre_categoria " +
                                                    "from CategoriaPuesto ", conexion);
            //----- 3-----//
            conexion.Open();
            SqlDataReader drCategorias = cmdLogin.ExecuteReader();
            LinkedList<CategoriaPuesto> categorias = new LinkedList<CategoriaPuesto>();
            while (drCategorias.Read())
            {

                //----------Libro----------//
                CategoriaPuesto categoria = new CategoriaPuesto();
                categoria.CodCategoria = Int32.Parse(drCategorias["cod_categoria"].ToString());
                categoria.NombreCategoria = drCategorias["nombre_categoria"].ToString();

                categorias.AddLast(categoria);


            }//fin while

            conexion.Close();

            return categorias;
        }

    }
}
