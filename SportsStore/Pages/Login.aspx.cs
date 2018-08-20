using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace SportsStore.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string name = Request.Form["name"];
                string password = Request.Form["password"];
 /* the following is a test of newer formsauthentication methods
  *               if (Membership.ValidateUser(name, password))
                {
                    FormsAuthentication.RedirectFromLoginPage(name, false);
                }
/* the following formsauthentication method is obsolete */
                  if (name != null && password != null
                    && FormsAuthentication.Authenticate(name, password))
                {
                    FormsAuthentication.SetAuthCookie(name, false);
                    Response.Redirect(Request["ReturnUrl"] ?? "/"); 
                }
                else
                {
                    ModelState.AddModelError("fail", "Login failed. Please try again");
                }
            }
        }
    }
}