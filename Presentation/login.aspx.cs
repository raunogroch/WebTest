using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLayer;

namespace Presentation
{
    public partial class index : System.Web.UI.Page
    {
        private BL_Users UserObject = new BL_Users();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            string email = getObject("txtEmail");
            string password = getObject("txtPassword");
            bool response = UserObject.authentication(email, password);
            if (response)
            {
                //alert("authentication correcta");
                Response.Redirect("home.aspx");
                
                // redirect to main googleAuthenticator page
            }
            else
            {
                alert("ERROR");
            }

            // back to login page
           
        }
        private string getObject(string value)
        {
            return Request[value];
        }
        private void alert(string message)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('" + message + "')", true);
        }
    }
}