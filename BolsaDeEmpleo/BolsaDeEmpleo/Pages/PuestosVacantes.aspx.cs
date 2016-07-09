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
    public partial class PuestosVacantes : System.Web.UI.Page
    {

        CategoriaPuestoBusiness categoriaBusiness = new CategoriaPuestoBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);
        PuestoOfertadoBusiness puestoBusiness = new PuestoOfertadoBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);
        public static int idSolicitante = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                LinkedList<CategoriaPuesto> categorias = categoriaBusiness.GetCategorias();
                ddlFiltroCategoria.DataSource = categorias;
                ddlFiltroCategoria.DataTextField = "nombreCategoria";
                ddlFiltroCategoria.DataValueField = "codCategoria";
                ddlFiltroCategoria.DataBind();
                idSolicitante = Int32.Parse(Session["id_usuario"].ToString());


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

        [WebMethod]
        public static string RegisterUser(string s)
        {
        
            if (idSolicitante != 0)
            {
                SolicitantePuestoOfertaBusiness solicitantePuestoOfertado = new SolicitantePuestoOfertaBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);
               
                if (solicitantePuestoOfertado.insertarSolicitud(idSolicitante, Int32.Parse(s)))
                {
                    return "Se aplicó correctamente a la Oferta";
                }
                return "Surgio un error con la  Oferta";
            }
            return "Surgio un error con la  Oferta";
        }
    }

}
