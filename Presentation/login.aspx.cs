using System;
using System.Web.UI;
using System.Web.Security;
using BussinessLayer;

namespace Presentation
{
    public partial class index : System.Web.UI.Page
    {
        private BL_Users UserObject = new BL_Users();
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            string email = getObject("txtEmail");
            string password = getObject("txtPassword");
            bool response = UserObject.authentication(email, password);
            if (response)
            {
                Session["login"] = true;
                FormsAuthentication.RedirectFromLoginPage(email, true);
            }
            else
            {
                Response.Redirect("login.aspx", true);
            }
           
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