using ScooldLibB05027.SchoolLibB05027.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShooldSysAppB05027
{
    public partial class InstructoresPorCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
               
                CarreraBusiness carreraBusiness = new CarreraBusiness(WebConfigurationManager.ConnectionStrings["Irazu"].ConnectionString);

                DataSet dsCarreras = new DataSet();

                dsCarreras = carreraBusiness.GetCarreras();
                

                ddlCarreras.DataSource =dsCarreras ;
                ddlCarreras.DataTextField = "nombre_carrera";
                ddlCarreras.DataValueField = "cod_carrera";
                ddlCarreras.DataBind();



               
           
             
            }
        }
    }
}
