using BolsaDeEmpleoLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaDeEmpleoLibrary.Business
{
   

    public class ContactoEmpleadorBusiness
    {
        private String conetionString;
        private ContactoEmpleadorData contactoEmpleadorData;

        public ContactoEmpleadorBusiness(string conetionString)
        {
            this.conetionString = conetionString;
            contactoEmpleadorData = new ContactoEmpleadorData(this.conetionString);
        }

        public int confirmLogin (String user, String pass)
        {
            return contactoEmpleadorData.confirmLogin(user, pass);
        }
    }
}
