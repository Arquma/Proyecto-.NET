using BolsaDeEmpleoLibrary.Business;
using BolsaDeEmpleoLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BolsaDeEmpleo.Account
{
    public partial class Registro : System.Web.UI.Page
    {
        
        InstitucionEstudioBusiness institucionBusiness = new InstitucionEstudioBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);
        NivelEstudioBusiness nivelBusiness = new NivelEstudioBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);
        AreaEspecialidadBusiness areaBusiness = new AreaEspecialidadBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                LinkedList<InstitucionEstudio> instituciones = institucionBusiness.GetInstituciones();
                ddlInstitucion.DataSource = instituciones;
                ddlInstitucion.DataTextField = "nombreInstitucion";
                ddlInstitucion.DataValueField = "codInstitucion";
                ddlInstitucion.DataBind();

                LinkedList<NivelEstudio> niveles = nivelBusiness.GetNivelEstudio();
                ddlArea.DataSource = niveles;
                ddlArea.DataTextField = "descripcionNivelEstudio";
                ddlArea.DataValueField = "codNivelEstudio";
                ddlArea.DataBind();

            }
        }
    }
}