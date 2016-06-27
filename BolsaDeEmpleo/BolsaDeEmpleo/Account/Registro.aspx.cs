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
        static LinkedList<ExperienciaLaboral> experiencias;

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
                ddlNivel.DataSource = niveles;
                ddlNivel.DataTextField = "descripcionNivelEstudio";
                ddlNivel.DataValueField = "codNivelEstudio";
                ddlNivel.DataBind();

                LinkedList<AreaEspecialidad> areas = areaBusiness.GetAreas();
                ddlArea.DataSource = areas;
                ddlArea.DataTextField = "descripcionAreaEspecialidad";
                ddlArea.DataValueField = "codAreaEspecialidad";
                ddlArea.DataBind();



                BoundField boundfield = new BoundField();
                boundfield.DataField = "Empresa";
                boundfield.HeaderText = "Empresa";

                BoundField boundfield1 = new BoundField();
                boundfield1.DataField = "DescripcionFunciones";
                boundfield1.HeaderText = "Descripcion Funciones";

                BoundField boundfield2 = new BoundField();
                boundfield2.DataField = "FechaIngreso";
                boundfield2.HeaderText = "Fecha Ingreso";

                BoundField boundfield3 = new BoundField();
                boundfield3.DataField = "FechaTermino";
                boundfield3.HeaderText = "Fecha Termino";

                gvtabla.Columns.Add(boundfield);
                gvtabla.Columns.Add(boundfield1);
                gvtabla.Columns.Add(boundfield2);
                gvtabla.Columns.Add(boundfield3);

                experiencias = new LinkedList<ExperienciaLaboral>();
                ExperienciaLaboral exp = new ExperienciaLaboral();
                exp.DescripcionFunciones = "algo";
                exp.Empresa = "ucr";
                exp.FechaIngreso = "123";
                exp.FechaTermino = "321";

                experiencias.AddLast(exp);
                gvtabla.DataSource = experiencias;
                gvtabla.AutoGenerateColumns = false;
                gvtabla.DataBind();
            }
        }

        protected void Guardar(object sender, EventArgs e)
        {
            AreaEspecialidad area = new AreaEspecialidad();
            InstitucionEstudio institucion = new InstitucionEstudio();
            NivelEstudio nivel = new NivelEstudio();
            LinkedList<ExperienciaLaboral> experiencias = new LinkedList<ExperienciaLaboral>();
            SolicitanteTrabajo solicitante = new SolicitanteTrabajo();
            EspecialidadSolicitante especialidad = new EspecialidadSolicitante();


            area.CodAreaEspecialidad = Int32.Parse(ddlArea.SelectedValue);
            institucion.CodInstitucion= Int32.Parse(ddlInstitucion.SelectedValue);
            nivel.CodNivelEstudio = Int32.Parse(ddlNivel.SelectedValue);

            solicitante.Nombre = Nombre.Text;
            solicitante.Genero = Genero.Text;
            solicitante.Email = Email.Text;
            solicitante.Direccion = Direccion.Text;
            solicitante.Apellidos = Apellidos.Text;
            solicitante.Ciudad = Ciudad.Text;
            solicitante.Clave = Pass.Text;
            solicitante.NombreUsuario = Usuario.Text;

          //  int num = tabla.Rows.Count;



        }
        protected void Agregar(object sender, EventArgs e)
        {


            ExperienciaLaboral exp = new ExperienciaLaboral();
            
            exp.Empresa = t1.Text;
            exp.DescripcionFunciones = t2.Text;
            exp.FechaIngreso = t3.Text;
            exp.FechaTermino = t4.Text;

            t1.Text="";
            t2.Text = "";
            t3.Text = "";
            t4.Text = "";


            experiencias.AddLast(exp);
            gvtabla.DataSource = experiencias;
           
            gvtabla.DataBind();


        }

        }
}