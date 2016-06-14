using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using BolsaDeEmpleo.Models;
using System.Web.Configuration;
using BolsaDeEmpleoLibrary.Business;

namespace BolsaDeEmpleo.Account
{
    public partial class Login : Page

      
    {
        ContactoEmpleadorBusiness contactoBuss = new ContactoEmpleadorBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);
        EmpleadoBusiness empleadoBuss = new EmpleadoBusiness(WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);

        String conn = (WebConfigurationManager.ConnectionStrings["BolsaEmpleo"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
           // RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            //OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            //var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            //if (!String.IsNullOrEmpty(returnUrl))
            //{
             //   RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            //}
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                //String result = //signinManager.PasswordSignIn(Email.Text, Password.Text, shouldLockout: false);
                String result;
                if (contactoBuss.confirmLogin(Email.Text, Password.Text))
                {
                     result = "Empleador";
                }
                
                else if (empleadoBuss.confirmLogin(Email.Text, Password.Text))
                {
                    result = "Solitante";
                }
                else if ((Email.Text=="admin") &&  (Password.Text=="admin"))
                {
                    result = "Administrador";
                }
                else
                {
                    result = "Error";
                }
                

                switch (result)
                {
                    case "Empleador":
                        Response.Redirect("~/Pages/InicioEmpleador.aspx");
                        break;
                    case "Solitante":
                        Response.Redirect("~/Pages/InicioSolicitante.aspx");
                        break;
                    case "Administrador":
                        Response.Redirect("~/Pages/InicioAdmin.aspx");
                        break;

                    case "Error":
                    default:
                        FailureText.Text = "Datos invalidos";
                        ErrorMessage.Visible = true;
                        break;
                }
            }
        }

        public string validarLogin(String usarname,String pass)
        {

            return "";
        }
    }
}