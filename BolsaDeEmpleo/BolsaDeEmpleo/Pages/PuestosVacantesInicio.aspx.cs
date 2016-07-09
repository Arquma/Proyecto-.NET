using BolsaDeEmpleoLibrary.Business;
using BolsaDeEmpleoLibrary.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BolsaDeEmpleo.Pages
{
    public partial class PuestosVacantesInicio : System.Web.UI.Page
    {

        CategoriaPuestoBusiness categoriaBusiness = new CategoriaPuestoBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);
        PuestoOfertadoBusiness puestoBusiness = new PuestoOfertadoBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);
      

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                LinkedList<CategoriaPuesto> categorias = categoriaBusiness.GetCategorias();
                ddlFiltroCategoria.DataSource = categorias;
                ddlFiltroCategoria.DataTextField = "nombreCategoria";
                ddlFiltroCategoria.DataValueField = "codCategoria";
                ddlFiltroCategoria.DataBind();
                
                
              


            }

        }


        protected void buscarPuestos(object sender, EventArgs e)
        {

            LinkedList<PuestoOfertado> puestos = puestoBusiness.GetOfertasPorCategoria(Int32.Parse(ddlFiltroCategoria.SelectedValue));
            // JSONArray jsonArray = new JSONArray(puestos);
            string json = "";
            if (puestos.Count != 0)
            {
                json = JsonConvert.SerializeObject(puestos);
            }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "myFunction('" + json + "')", true);

        }

       
    }

}
