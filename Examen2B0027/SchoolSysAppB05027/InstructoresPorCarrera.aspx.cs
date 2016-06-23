using ScooldLibB05027.SchoolLibB05027.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolSysAppB05027
{
    public partial class InstructoresPorCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                CarreraBusiness carreraBusiness = new CarreraBusiness(WebConfigurationManager.ConnectionStrings["IrazuSchool"].ConnectionString);

                DataSet dsCarreras = new DataSet();

                dsCarreras = carreraBusiness.GetCarreras();
                
                ddlCarreras.DataSource = dsCarreras;
                ddlCarreras.DataTextField = "nombre_carrera";
                ddlCarreras.DataValueField = "cod_carrera";
                ddlCarreras.DataBind();

                ddlCarreras.SelectedIndex = ddlCarreras.Items.Count-1;
                
            }
        }

        protected void ddlCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {

            InstuctorBusiness instructorBusiness = new InstuctorBusiness(WebConfigurationManager.ConnectionStrings["IrazuSchool"].ConnectionString);
           gvInstructores.DataSource= (instructorBusiness.GetInstructores(Int32.Parse(ddlCarreras.SelectedItem.Value)));
           
            gvInstructores.DataBind();
        }

        protected void gvInstructores_PageIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}